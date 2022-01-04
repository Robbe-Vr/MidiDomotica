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
        private void onTimerElapsedMode6(object sender, ElapsedEventArgs e)
        {
            if (timer != null && timer.Enabled)
            {
                timer.Stop();
            }

            var lastNote = notePressHistory.LastOrDefault();

            if (lastNote != null)
            {
                object key = this[$"Mode6_{lastNote.Note}_{lastNote.NoteIndex}_NoteHeldEventKey"];

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

        public void NotePressedMode6(MidiMessageRecievedEventArgs e)
        {
            SetMode(6);

            DateTime timeNow = DateTime.Now;

            timer = new Timer(MsForHold);
            timer.Elapsed += onTimerElapsedMode6;
            timer.AutoReset = false;
            timer.Start();

            var lastNote = notePressHistory.LastOrDefault(n => n.NoteIndex == e.Message.Data1);

            int noteIndex = e.Message.Data1;
            string noteName = NoteForIndex(noteIndex).ToString();

            if (lastNote != null && timeNow.Subtract(lastNote.TimeStamp).TotalMilliseconds < MsForDoubleClick)
            {
                object key = this[$"Mode6_{noteName}_{noteIndex}_NoteOnDoubleClickEventKey"];

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

                object key = this[$"Mode6_{noteName}_{noteIndex}_NoteOnEventKey"];

                ((EventHandler<OnNoteOnEventArgs>)listEventDelegates[key])?.Invoke(this, new OnNoteOnEventArgs()
                {
                    DeviceName = "Novation SL MK3",
                    NoteIndex = e.Message.Data1,
                    Note = NoteForIndex(e.Message.Data1).ToString(),
                    Intensity = e.Message.Data2,
                });
            }
        }

        private void NoteReleasedMode6(MidiMessageRecievedEventArgs e)
        {
            SetMode(6);

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
                object key = this[$"Mode6_{noteName}_{noteIndex}_NoteOffDelayedEventKey"];

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
                        object key = this[$"Mode6_{noteName}_{noteIndex}_NoteOffDoubleClickEventKey"];

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
                    object key = this[$"Mode6_{noteName}_{noteIndex}_NoteOffEventKey"];

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

        private void ControlChangedMode6(MidiMessageRecievedEventArgs e)
        {
            SetMode(6);

            if (e.Message.Data1 > 50 && e.Message.Data1 < 59) // Top Row Fader Buttons
            {
                if (e.Message.Data2 == 127) // Pressed
                {
                    object[] keys = new object[] {
                      Mode6FaderButton1PressedEventKey,
                      Mode6FaderButton2PressedEventKey,
                      Mode6FaderButton3PressedEventKey,
                      Mode6FaderButton4PressedEventKey,
                      Mode6FaderButton5PressedEventKey,
                      Mode6FaderButton6PressedEventKey,
                      Mode6FaderButton7PressedEventKey,
                      Mode6FaderButton8PressedEventKey,
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
                      Mode6FaderButton1ReleasedEventKey,
                      Mode6FaderButton2ReleasedEventKey,
                      Mode6FaderButton3ReleasedEventKey,
                      Mode6FaderButton4ReleasedEventKey,
                      Mode6FaderButton5ReleasedEventKey,
                      Mode6FaderButton6ReleasedEventKey,
                      Mode6FaderButton7ReleasedEventKey,
                      Mode6FaderButton8ReleasedEventKey,
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
                      Mode6FaderButton9PressedEventKey,
                      Mode6FaderButton10PressedEventKey,
                      Mode6FaderButton11PressedEventKey,
                      Mode6FaderButton12PressedEventKey,
                      Mode6FaderButton13PressedEventKey,
                      Mode6FaderButton14PressedEventKey,
                      Mode6FaderButton15PressedEventKey,
                      Mode6FaderButton16PressedEventKey,
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
                      Mode6FaderButton9ReleasedEventKey,
                      Mode6FaderButton10ReleasedEventKey,
                      Mode6FaderButton11ReleasedEventKey,
                      Mode6FaderButton12ReleasedEventKey,
                      Mode6FaderButton13ReleasedEventKey,
                      Mode6FaderButton14ReleasedEventKey,
                      Mode6FaderButton15ReleasedEventKey,
                      Mode6FaderButton16ReleasedEventKey,
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
                      Mode6SlideFader1ChangedEventKey,
                      Mode6SlideFader2ChangedEventKey,
                      Mode6SlideFader3ChangedEventKey,
                      Mode6SlideFader4ChangedEventKey,
                      Mode6SlideFader5ChangedEventKey,
                      Mode6SlideFader6ChangedEventKey,
                      Mode6SlideFader7ChangedEventKey,
                      Mode6SlideFader8ChangedEventKey,
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
                      Mode6KnobFader1ChangedEventKey,
                      Mode6KnobFader2ChangedEventKey,
                      Mode6KnobFader3ChangedEventKey,
                      Mode6KnobFader4ChangedEventKey,
                      Mode6KnobFader5ChangedEventKey,
                      Mode6KnobFader6ChangedEventKey,
                      Mode6KnobFader7ChangedEventKey,
                      Mode6KnobFader8ChangedEventKey,
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

                object key = Mode6ModulationBendEventKey;

                ((EventHandler<OnModulationBendEventArgs>)listEventDelegates[key])?.Invoke(this, new OnModulationBendEventArgs()
                {
                    DeviceName = "Novation SL MK3",
                    ModulationBendValue = modvolume,
                });
            }
        }

        private void PitchWheelChangedMode6(MidiMessageRecievedEventArgs e)
        {
            SetMode(6);

            int pitchinter = e.Message.Data1;
            int pitchvalue = e.Message.Data2;

            object key = Mode6PitchBendEventKey;

            ((EventHandler<OnPitchBendEventArgs>)listEventDelegates[key])?.Invoke(this, new OnPitchBendEventArgs()
            {
                DeviceName = "Novation SL MK3",
                PitchBendValue = pitchvalue,
            });
        }
    }
}
