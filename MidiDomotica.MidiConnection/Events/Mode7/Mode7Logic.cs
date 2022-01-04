using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using MidiDomotica.Exchange.ControlEvents;

namespace MidiDomotica.MidiConnection.Events
{
    public partial class EventsMapper
    {
        private void onTimerElapsedMode7(object sender, ElapsedEventArgs e)
        {
            if (timer != null && timer.Enabled)
            {
                timer.Stop();
            }

            var lastNote = notePressHistory.LastOrDefault();

            if (lastNote != null)
            {
                object key = this[$"Mode7_{lastNote.Note}_{lastNote.NoteIndex}_NoteHeldEventKey"];

                ((EventHandler<OnNoteHoldEventArgs>)listEventDelegates[key])?.Invoke(this, new OnNoteHoldEventArgs()
                {
                    NoteIndex = lastNote.NoteIndex,
                    Note = lastNote.Note,
                    Intensity = lastNote.Intensity,
                    DeviceName = "Novation SL MK3",
                });
            }

            if (timer != null && repeating)
            {
                timer.Start();
            }
        }

        public void NotePressedMode7(MidiMessageRecievedEventArgs e)
        {
            SetMode(7);

            DateTime timeNow = DateTime.Now;

            timer = new Timer(MsForHold);
            timer.Elapsed += onTimerElapsedMode7;
            timer.AutoReset = false;
            timer.Start();

            var lastNote = notePressHistory.LastOrDefault(n => n.NoteIndex == e.Message.Data1);

            int noteIndex = e.Message.Data1;
            string noteName = NoteForIndex(noteIndex).ToString();

            if (lastNote != null && timeNow.Subtract(lastNote.TimeStamp).TotalMilliseconds < MsForDoubleClick)
            {
                object key = this[$"Mode7_{noteName}_{noteIndex}_NoteOnDoubleClickEventKey"];

                ((EventHandler<OnNoteOnEventArgs>)listEventDelegates[key])?.Invoke(this, new OnNoteOnEventArgs()
                {
                    DeviceName = "Novation SL MK3",
                    Note = NoteForIndex(e.Message.Data1).ToString(),
                    NoteIndex = e.Message.Data1,
                    Intensity = e.Message.Data2,
                });
            }
            else
            {
                notePressHistory.Add(new NotePressedData()
                {
                    NoteIndex = e.Message.Data1,
                    Note = NoteForIndex(e.Message.Data1).ToString(),
                    Intensity = e.Message.Data2,
                    TimeStamp = DateTime.Now,
                });

                object key = this[$"Mode7_{noteName}_{noteIndex}_NoteOnEventKey"];

                ((EventHandler<OnNoteOnEventArgs>)listEventDelegates[key])?.Invoke(this, new OnNoteOnEventArgs()
                {
                    DeviceName = "Novation SL MK3",
                    NoteIndex = e.Message.Data1,
                    Note = NoteForIndex(e.Message.Data1).ToString(),
                    Intensity = e.Message.Data2,
                });
            }
        }

        private void NoteReleasedMode7(MidiMessageRecievedEventArgs e)
        {
            SetMode(7);

            var timeNow = DateTime.Now;
            var lastNote = notePressHistory.LastOrDefault(n => n.NoteIndex == e.Message.Data1);
            var timeHeld = timeNow.Subtract(lastNote.TimeStamp);

            noteReleaseHistory.Add(new NotePressedData()
            {
                NoteIndex = e.Message.Data1,
                Note = NoteForIndex(e.Message.Data1).ToString(),
                Intensity = e.Message.Data2,
                TimeStamp = DateTime.Now,
            });

            int noteIndex = e.Message.Data1;
            string noteName = NoteForIndex(noteIndex).ToString();

            if (timeHeld.TotalMilliseconds > MsForHold)
            {
                object key = this[$"Mode7_{noteName}_{noteIndex}_NoteOffDelayedEventKey"];

                ((EventHandler<OnNoteOffDelayedEventArgs>)listEventDelegates[key])?.Invoke(this, new OnNoteOffDelayedEventArgs()
                {
                    DeviceName = "Novation SL MK3",
                    NoteIndex = e.Message.Data1,
                    Note = NoteForIndex(e.Message.Data1).ToString(),
                    TimeHeld = timeHeld,
                });
            }
            else
            {
                NotePressedData note = noteReleaseHistory.LastOrDefault(n => n.NoteIndex == e.Message.Data1);

                if (note != null)
                {
                    if (lastNote != null && timeHeld.TotalMilliseconds < MsForDoubleClick)
                    {
                        object key = this[$"Mode7_{noteName}_{noteIndex}_NoteOffDoubleClickEventKey"];

                        ((EventHandler<OnNoteOffEventArgs>)listEventDelegates[key])?.Invoke(this, new OnNoteOffEventArgs()
                        {
                            DeviceName = "Novation SL MK3",
                            Note = NoteForIndex(e.Message.Data1).ToString(),
                            NoteIndex = e.Message.Data1,
                            TimeHeld = timeHeld,
                        });

                    }
                }
                else
                {
                    object key = this[$"Mode7_{noteName}_{noteIndex}_NoteOffEventKey"];

                    ((EventHandler<OnNoteOffEventArgs>)listEventDelegates[key])?.Invoke(this, new OnNoteOffEventArgs()
                    {
                        DeviceName = "Novation SL MK3",
                        NoteIndex = e.Message.Data1,
                        Note = NoteForIndex(e.Message.Data1).ToString(),
                        TimeHeld = timeHeld,
                    });
                }

                if (timer != null)
                {
                    timer.Stop();
                    timer.Dispose();
                    timer = null;
                }
            }
        }

        private void ControlChangedMode7(MidiMessageRecievedEventArgs e)
        {
            SetMode(7);

            if (e.Message.Data1 > 50 && e.Message.Data1 < 59) // Top Row Fader Buttons
            {
                if (e.Message.Data2 == 127) // Pressed
                {
                    object[] keys = new object[] {
                      Mode7FaderButton1PressedEventKey,
                      Mode7FaderButton2PressedEventKey,
                      Mode7FaderButton3PressedEventKey,
                      Mode7FaderButton4PressedEventKey,
                      Mode7FaderButton5PressedEventKey,
                      Mode7FaderButton6PressedEventKey,
                      Mode7FaderButton7PressedEventKey,
                      Mode7FaderButton8PressedEventKey,
                    };

                    switch (e.Message.Data1)
                    {
                        case 51:
                            ((EventHandler<OnFaderButtonEventArgs>)listEventDelegates[keys[0]])?.Invoke(this, new OnFaderButtonEventArgs()
                            {
                                DeviceName = "Novation SL MK3",
                                FaderButtonIndex = e.Message.Data1,
                                Value = e.Message.Data2,
                            });
                            break;
                        case 52:
                            ((EventHandler<OnFaderButtonEventArgs>)listEventDelegates[keys[1]])?.Invoke(this, new OnFaderButtonEventArgs()
                            {
                                DeviceName = "Novation SL MK3",
                                FaderButtonIndex = e.Message.Data1,
                                Value = e.Message.Data2,
                            });
                            break;
                        case 53:
                            ((EventHandler<OnFaderButtonEventArgs>)listEventDelegates[keys[2]])?.Invoke(this, new OnFaderButtonEventArgs()
                            {
                                DeviceName = "Novation SL MK3",
                                FaderButtonIndex = e.Message.Data1,
                                Value = e.Message.Data2,
                            });
                            break;
                        case 54:
                            ((EventHandler<OnFaderButtonEventArgs>)listEventDelegates[keys[3]])?.Invoke(this, new OnFaderButtonEventArgs()
                            {
                                DeviceName = "Novation SL MK3",
                                FaderButtonIndex = e.Message.Data1,
                                Value = e.Message.Data2,
                            });
                            break;
                        case 55:
                            ((EventHandler<OnFaderButtonEventArgs>)listEventDelegates[keys[4]])?.Invoke(this, new OnFaderButtonEventArgs()
                            {
                                DeviceName = "Novation SL MK3",
                                FaderButtonIndex = e.Message.Data1,
                                Value = e.Message.Data2,
                            });
                            break;
                        case 56:
                            ((EventHandler<OnFaderButtonEventArgs>)listEventDelegates[keys[5]])?.Invoke(this, new OnFaderButtonEventArgs()
                            {
                                DeviceName = "Novation SL MK3",
                                FaderButtonIndex = e.Message.Data1,
                                Value = e.Message.Data2,
                            });
                            break;
                        case 57:
                            ((EventHandler<OnFaderButtonEventArgs>)listEventDelegates[keys[6]])?.Invoke(this, new OnFaderButtonEventArgs()
                            {
                                DeviceName = "Novation SL MK3",
                                FaderButtonIndex = e.Message.Data1,
                                Value = e.Message.Data2,
                            });
                            break;
                        case 58:
                            ((EventHandler<OnFaderButtonEventArgs>)listEventDelegates[keys[7]])?.Invoke(this, new OnFaderButtonEventArgs()
                            {
                                DeviceName = "Novation SL MK3",
                                FaderButtonIndex = e.Message.Data1,
                                Value = e.Message.Data2,
                            });
                            break;
                    }
                }
                else if (e.Message.Data2 == 0) // Released
                {
                    object[] keys = new object[] {
                      Mode7FaderButton1ReleasedEventKey,
                      Mode7FaderButton2ReleasedEventKey,
                      Mode7FaderButton3ReleasedEventKey,
                      Mode7FaderButton4ReleasedEventKey,
                      Mode7FaderButton5ReleasedEventKey,
                      Mode7FaderButton6ReleasedEventKey,
                      Mode7FaderButton7ReleasedEventKey,
                      Mode7FaderButton8ReleasedEventKey,
                    };

                    switch (e.Message.Data1)
                    {
                        case 51:
                            ((EventHandler<OnFaderButtonEventArgs>)listEventDelegates[keys[0]])?.Invoke(this, new OnFaderButtonEventArgs()
                            {
                                DeviceName = "Novation SL MK3",
                                FaderButtonIndex = e.Message.Data1,
                                Value = e.Message.Data2,
                            });
                            break;
                        case 52:
                            ((EventHandler<OnFaderButtonEventArgs>)listEventDelegates[keys[1]])?.Invoke(this, new OnFaderButtonEventArgs()
                            {
                                DeviceName = "Novation SL MK3",
                                FaderButtonIndex = e.Message.Data1,
                                Value = e.Message.Data2,
                            });
                            break;
                        case 53:
                            ((EventHandler<OnFaderButtonEventArgs>)listEventDelegates[keys[2]])?.Invoke(this, new OnFaderButtonEventArgs()
                            {
                                DeviceName = "Novation SL MK3",
                                FaderButtonIndex = e.Message.Data1,
                                Value = e.Message.Data2,
                            });
                            break;
                        case 54:
                            ((EventHandler<OnFaderButtonEventArgs>)listEventDelegates[keys[3]])?.Invoke(this, new OnFaderButtonEventArgs()
                            {
                                DeviceName = "Novation SL MK3",
                                FaderButtonIndex = e.Message.Data1,
                                Value = e.Message.Data2,
                            });
                            break;
                        case 55:
                            ((EventHandler<OnFaderButtonEventArgs>)listEventDelegates[keys[4]])?.Invoke(this, new OnFaderButtonEventArgs()
                            {
                                DeviceName = "Novation SL MK3",
                                FaderButtonIndex = e.Message.Data1,
                                Value = e.Message.Data2,
                            });
                            break;
                        case 56:
                            ((EventHandler<OnFaderButtonEventArgs>)listEventDelegates[keys[5]])?.Invoke(this, new OnFaderButtonEventArgs()
                            {
                                DeviceName = "Novation SL MK3",
                                FaderButtonIndex = e.Message.Data1,
                                Value = e.Message.Data2,
                            });
                            break;
                        case 57:
                            ((EventHandler<OnFaderButtonEventArgs>)listEventDelegates[keys[6]])?.Invoke(this, new OnFaderButtonEventArgs()
                            {
                                DeviceName = "Novation SL MK3",
                                FaderButtonIndex = e.Message.Data1,
                                Value = e.Message.Data2,
                            });
                            break;
                        case 58:
                            ((EventHandler<OnFaderButtonEventArgs>)listEventDelegates[keys[7]])?.Invoke(this, new OnFaderButtonEventArgs()
                            {
                                DeviceName = "Novation SL MK3",
                                FaderButtonIndex = e.Message.Data1,
                                Value = e.Message.Data2,
                            });
                            break;
                    }
                }
            }
            else if (e.Message.Data1 > 70 && e.Message.Data1 < 79) // Bottom Row Fader Buttons
            {
                if (e.Message.Data2 == 127) // Pressed
                {
                    object[] keys = new object[] {
                      Mode7FaderButton9PressedEventKey,
                      Mode7FaderButton10PressedEventKey,
                      Mode7FaderButton11PressedEventKey,
                      Mode7FaderButton12PressedEventKey,
                      Mode7FaderButton13PressedEventKey,
                      Mode7FaderButton14PressedEventKey,
                      Mode7FaderButton15PressedEventKey,
                      Mode7FaderButton16PressedEventKey,
                    };

                    switch (e.Message.Data1)
                    {
                        case 71:
                            ((EventHandler<OnFaderButtonEventArgs>)listEventDelegates[keys[0]])?.Invoke(this, new OnFaderButtonEventArgs()
                            {
                                DeviceName = "Novation SL MK3",
                                FaderButtonIndex = e.Message.Data1,
                                Value = e.Message.Data2,
                            });
                            break;
                        case 72:
                            ((EventHandler<OnFaderButtonEventArgs>)listEventDelegates[keys[1]])?.Invoke(this, new OnFaderButtonEventArgs()
                            {
                                DeviceName = "Novation SL MK3",
                                FaderButtonIndex = e.Message.Data1,
                                Value = e.Message.Data2,
                            });
                            break;
                        case 73:
                            ((EventHandler<OnFaderButtonEventArgs>)listEventDelegates[keys[2]])?.Invoke(this, new OnFaderButtonEventArgs()
                            {
                                DeviceName = "Novation SL MK3",
                                FaderButtonIndex = e.Message.Data1,
                                Value = e.Message.Data2,
                            });
                            break;
                        case 74:
                            ((EventHandler<OnFaderButtonEventArgs>)listEventDelegates[keys[3]])?.Invoke(this, new OnFaderButtonEventArgs()
                            {
                                DeviceName = "Novation SL MK3",
                                FaderButtonIndex = e.Message.Data1,
                                Value = e.Message.Data2,
                            });
                            break;
                        case 75:
                            ((EventHandler<OnFaderButtonEventArgs>)listEventDelegates[keys[4]])?.Invoke(this, new OnFaderButtonEventArgs()
                            {
                                DeviceName = "Novation SL MK3",
                                FaderButtonIndex = e.Message.Data1,
                                Value = e.Message.Data2,
                            });
                            break;
                        case 76:
                            ((EventHandler<OnFaderButtonEventArgs>)listEventDelegates[keys[5]])?.Invoke(this, new OnFaderButtonEventArgs()
                            {
                                DeviceName = "Novation SL MK3",
                                FaderButtonIndex = e.Message.Data1,
                                Value = e.Message.Data2,
                            });
                            break;
                        case 77:
                            ((EventHandler<OnFaderButtonEventArgs>)listEventDelegates[keys[6]])?.Invoke(this, new OnFaderButtonEventArgs()
                            {
                                DeviceName = "Novation SL MK3",
                                FaderButtonIndex = e.Message.Data1,
                                Value = e.Message.Data2,
                            });
                            break;
                        case 78:
                            ((EventHandler<OnFaderButtonEventArgs>)listEventDelegates[keys[7]])?.Invoke(this, new OnFaderButtonEventArgs()
                            {
                                DeviceName = "Novation SL MK3",
                                FaderButtonIndex = e.Message.Data1,
                                Value = e.Message.Data2,
                            });
                            break;
                    }
                }
                else if (e.Message.Data2 == 0) // Released
                {
                    object[] keys = new object[] {
                      Mode7FaderButton9ReleasedEventKey,
                      Mode7FaderButton10ReleasedEventKey,
                      Mode7FaderButton11ReleasedEventKey,
                      Mode7FaderButton12ReleasedEventKey,
                      Mode7FaderButton13ReleasedEventKey,
                      Mode7FaderButton14ReleasedEventKey,
                      Mode7FaderButton15ReleasedEventKey,
                      Mode7FaderButton16ReleasedEventKey,
                    };

                    switch (e.Message.Data1)
                    {
                        case 71:
                            ((EventHandler<OnFaderButtonEventArgs>)listEventDelegates[keys[0]])?.Invoke(this, new OnFaderButtonEventArgs()
                            {
                                DeviceName = "Novation SL MK3",
                                FaderButtonIndex = e.Message.Data1,
                                Value = e.Message.Data2,
                            });
                            break;
                        case 72:
                            ((EventHandler<OnFaderButtonEventArgs>)listEventDelegates[keys[1]])?.Invoke(this, new OnFaderButtonEventArgs()
                            {
                                DeviceName = "Novation SL MK3",
                                FaderButtonIndex = e.Message.Data1,
                                Value = e.Message.Data2,
                            });
                            break;
                        case 73:
                            ((EventHandler<OnFaderButtonEventArgs>)listEventDelegates[keys[2]])?.Invoke(this, new OnFaderButtonEventArgs()
                            {
                                DeviceName = "Novation SL MK3",
                                FaderButtonIndex = e.Message.Data1,
                                Value = e.Message.Data2,
                            });
                            break;
                        case 74:
                            ((EventHandler<OnFaderButtonEventArgs>)listEventDelegates[keys[3]])?.Invoke(this, new OnFaderButtonEventArgs()
                            {
                                DeviceName = "Novation SL MK3",
                                FaderButtonIndex = e.Message.Data1,
                                Value = e.Message.Data2,
                            });
                            break;
                        case 75:
                            ((EventHandler<OnFaderButtonEventArgs>)listEventDelegates[keys[4]])?.Invoke(this, new OnFaderButtonEventArgs()
                            {
                                DeviceName = "Novation SL MK3",
                                FaderButtonIndex = e.Message.Data1,
                                Value = e.Message.Data2,
                            });
                            break;
                        case 76:
                            ((EventHandler<OnFaderButtonEventArgs>)listEventDelegates[keys[5]])?.Invoke(this, new OnFaderButtonEventArgs()
                            {
                                DeviceName = "Novation SL MK3",
                                FaderButtonIndex = e.Message.Data1,
                                Value = e.Message.Data2,
                            });
                            break;
                        case 77:
                            ((EventHandler<OnFaderButtonEventArgs>)listEventDelegates[keys[6]])?.Invoke(this, new OnFaderButtonEventArgs()
                            {
                                DeviceName = "Novation SL MK3",
                                FaderButtonIndex = e.Message.Data1,
                                Value = e.Message.Data2,
                            });
                            break;
                        case 78:
                            ((EventHandler<OnFaderButtonEventArgs>)listEventDelegates[keys[7]])?.Invoke(this, new OnFaderButtonEventArgs()
                            {
                                DeviceName = "Novation SL MK3",
                                FaderButtonIndex = e.Message.Data1,
                                Value = e.Message.Data2,
                            });
                            break;
                    }
                }
            }
            else if (e.Message.Data1 > 40 && e.Message.Data1 < 49) // Slide Faders
            {
                float slidevalue = e.Message.Data2 / 127.00f;

                int slidevolume = (int)((slidevalue * 100.00) + 0.5);

                object[] keys = new object[] {
                      Mode7SlideFader1ChangedEventKey,
                      Mode7SlideFader2ChangedEventKey,
                      Mode7SlideFader3ChangedEventKey,
                      Mode7SlideFader4ChangedEventKey,
                      Mode7SlideFader5ChangedEventKey,
                      Mode7SlideFader6ChangedEventKey,
                      Mode7SlideFader7ChangedEventKey,
                      Mode7SlideFader8ChangedEventKey,
                };

                switch (e.Message.Data1)
                {
                    case 41:
                        ((EventHandler<OnSlideFaderEventArgs>)listEventDelegates[keys[0]])?.Invoke(this, new OnSlideFaderEventArgs()
                        {
                            DeviceName = "Novation SL MK3",
                            SlideFaderIndex = e.Message.Data1,
                            Value = slidevolume,
                        });
                        break;
                    case 42:
                        ((EventHandler<OnSlideFaderEventArgs>)listEventDelegates[keys[1]])?.Invoke(this, new OnSlideFaderEventArgs()
                        {
                            DeviceName = "Novation SL MK3",
                            SlideFaderIndex = e.Message.Data1,
                            Value = slidevolume,
                        });
                        break;
                    case 43:
                        ((EventHandler<OnSlideFaderEventArgs>)listEventDelegates[keys[2]])?.Invoke(this, new OnSlideFaderEventArgs()
                        {
                            DeviceName = "Novation SL MK3",
                            SlideFaderIndex = e.Message.Data1,
                            Value = slidevolume,
                        });
                        break;
                    case 44:
                        ((EventHandler<OnSlideFaderEventArgs>)listEventDelegates[keys[3]])?.Invoke(this, new OnSlideFaderEventArgs()
                        {
                            DeviceName = "Novation SL MK3",
                            SlideFaderIndex = e.Message.Data1,
                            Value = slidevolume,
                        });
                        break;
                    case 45:
                        ((EventHandler<OnSlideFaderEventArgs>)listEventDelegates[keys[4]])?.Invoke(this, new OnSlideFaderEventArgs()
                        {
                            DeviceName = "Novation SL MK3",
                            SlideFaderIndex = e.Message.Data1,
                            Value = slidevolume,
                        });
                        break;
                    case 46:
                        ((EventHandler<OnSlideFaderEventArgs>)listEventDelegates[keys[5]])?.Invoke(this, new OnSlideFaderEventArgs()
                        {
                            DeviceName = "Novation SL MK3",
                            SlideFaderIndex = e.Message.Data1,
                            Value = slidevolume,
                        });
                        break;
                    case 47:
                        ((EventHandler<OnSlideFaderEventArgs>)listEventDelegates[keys[6]])?.Invoke(this, new OnSlideFaderEventArgs()
                        {
                            DeviceName = "Novation SL MK3",
                            SlideFaderIndex = e.Message.Data1,
                            Value = slidevolume,
                        });
                        break;
                    case 48:
                        ((EventHandler<OnSlideFaderEventArgs>)listEventDelegates[keys[7]])?.Invoke(this, new OnSlideFaderEventArgs()
                        {
                            DeviceName = "Novation SL MK3",
                            SlideFaderIndex = e.Message.Data1,
                            Value = slidevolume,
                        });
                        break;
                }
            }
            else if (e.Message.Data1 > 20 && e.Message.Data1 < 29) // Top Mid Knob Faders
            {
                float knobvalue = e.Message.Data2 / 127.00f;

                int knobvolume = (int)((knobvalue * 100) + 0.5);

                object[] keys = new object[] {
                      Mode7KnobFader1ChangedEventKey,
                      Mode7KnobFader2ChangedEventKey,
                      Mode7KnobFader3ChangedEventKey,
                      Mode7KnobFader4ChangedEventKey,
                      Mode7KnobFader5ChangedEventKey,
                      Mode7KnobFader6ChangedEventKey,
                      Mode7KnobFader7ChangedEventKey,
                      Mode7KnobFader8ChangedEventKey,
                };

                switch (e.Message.Data1)
                {
                    case 41:
                        ((EventHandler<OnKnobFaderEventArgs>)listEventDelegates[keys[0]])?.Invoke(this, new OnKnobFaderEventArgs()
                        {
                            DeviceName = "Novation SL MK3",
                            KnobFaderIndex = e.Message.Data1,
                            Value = knobvolume,
                        });
                        break;
                    case 42:
                        ((EventHandler<OnKnobFaderEventArgs>)listEventDelegates[keys[1]])?.Invoke(this, new OnKnobFaderEventArgs()
                        {
                            DeviceName = "Novation SL MK3",
                            KnobFaderIndex = e.Message.Data1,
                            Value = knobvolume,
                        });
                        break;
                    case 43:
                        ((EventHandler<OnKnobFaderEventArgs>)listEventDelegates[keys[2]])?.Invoke(this, new OnKnobFaderEventArgs()
                        {
                            DeviceName = "Novation SL MK3",
                            KnobFaderIndex = e.Message.Data1,
                            Value = knobvolume,
                        });
                        break;
                    case 44:
                        ((EventHandler<OnKnobFaderEventArgs>)listEventDelegates[keys[3]])?.Invoke(this, new OnKnobFaderEventArgs()
                        {
                            DeviceName = "Novation SL MK3",
                            KnobFaderIndex = e.Message.Data1,
                            Value = knobvolume,
                        });
                        break;
                    case 45:
                        ((EventHandler<OnKnobFaderEventArgs>)listEventDelegates[keys[4]])?.Invoke(this, new OnKnobFaderEventArgs()
                        {
                            DeviceName = "Novation SL MK3",
                            KnobFaderIndex = e.Message.Data1,
                            Value = knobvolume,
                        });
                        break;
                    case 46:
                        ((EventHandler<OnKnobFaderEventArgs>)listEventDelegates[keys[5]])?.Invoke(this, new OnKnobFaderEventArgs()
                        {
                            DeviceName = "Novation SL MK3",
                            KnobFaderIndex = e.Message.Data1,
                            Value = knobvolume,
                        });
                        break;
                    case 47:
                        ((EventHandler<OnKnobFaderEventArgs>)listEventDelegates[keys[6]])?.Invoke(this, new OnKnobFaderEventArgs()
                        {
                            DeviceName = "Novation SL MK3",
                            KnobFaderIndex = e.Message.Data1,
                            Value = knobvolume,
                        });
                        break;
                    case 48:
                        ((EventHandler<OnKnobFaderEventArgs>)listEventDelegates[keys[7]])?.Invoke(this, new OnKnobFaderEventArgs()
                        {
                            DeviceName = "Novation SL MK3",
                            KnobFaderIndex = e.Message.Data1,
                            Value = knobvolume,
                        });
                        break;
                }
            }
            else if (e.Message.Data1 == 1) // Modulation Wheel
            {
                float modvalue = e.Message.Data2 / 127.00f;

                int modvolume = (int)((modvalue * 100) + 0.5);

                object key = Mode7ModulationBendEventKey;

                ((EventHandler<OnModulationBendEventArgs>)listEventDelegates[key])?.Invoke(this, new OnModulationBendEventArgs()
                {
                    DeviceName = "Novation SL MK3",
                    ModulationBendValue = modvolume,
                });
            }
        }

        private void PitchWheelChangedMode7(MidiMessageRecievedEventArgs e)
        {
            SetMode(7);

            int pitchinter = e.Message.Data1;
            int pitchvalue = e.Message.Data2;

            object key = Mode7PitchBendEventKey;

            ((EventHandler<OnPitchBendEventArgs>)listEventDelegates[key])?.Invoke(this, new OnPitchBendEventArgs()
            {
                DeviceName = "Novation SL MK3",
                PitchBendValue = pitchvalue,
            });
        }
    }
}
