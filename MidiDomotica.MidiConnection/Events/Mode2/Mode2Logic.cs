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
        private void onTimerElapsedMode2(object sender, ElapsedEventArgs e)
        {
            if (timer != null && timer.Enabled)
            {
                timer.Stop();
            }

            var lastNote = notePressHistory.LastOrDefault();

            if (lastNote != null)
            {
                object key = this[$"Mode2_{lastNote.Note}_{lastNote.NoteIndex}_NoteHeldEventKey"];

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

        private void NotePressedMode2(MidiMessageRecievedEventArgs e)
        {
            SetMode(2);

            DateTime timeNow = DateTime.Now;

            timer = new Timer(MsForHold);
            timer.Elapsed += onTimerElapsedMode2;
            timer.AutoReset = false;
            timer.Start();

            var lastNote = notePressHistory.LastOrDefault(n => n.NoteIndex == e.Message.Data1);

            int noteIndex = e.Message.Data1;
            string noteName = NoteForIndex(noteIndex).ToString();

            if (lastNote != null && timeNow.Subtract(lastNote.TimeStamp).TotalMilliseconds < MsForDoubleClick)
            {
                object key = this[$"Mode2_{noteName}_{noteIndex}_NoteOnDoubleClickEventKey"];

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

                object key = this[$"Mode2_{noteName}_{noteIndex}_NoteOnEventKey"];

                ((EventHandler<OnNoteOnEventArgs>)listEventDelegates[key])?.Invoke(this, new OnNoteOnEventArgs()
                {
                    DeviceName = "Novation SL MK3",
                    NoteIndex = e.Message.Data1,
                    Note = NoteForIndex(e.Message.Data1).ToString(),
                    Intensity = e.Message.Data2,
                });
            }
        }

        private void NoteReleasedMode2(MidiMessageRecievedEventArgs e)
        {
            SetMode(2);

            var timeNow = DateTime.Now;
            var lastNote = notePressHistory.LastOrDefault(n => n.NoteIndex == e.Message.Data1);
            var timeHeld = timeNow.Subtract(lastNote.TimeStamp);

            int noteIndex = e.Message.Data1;
            string noteName = NoteForIndex(noteIndex).ToString();

            noteReleaseHistory.Add(new NotePressedData()
            {
                NoteIndex = e.Message.Data1,
                Note = NoteForIndex(e.Message.Data1).ToString(),
                Intensity = e.Message.Data2,
                TimeStamp = DateTime.Now,
            });

            if (timeHeld.TotalMilliseconds > MsForHold)
            {
                object key = this[$"Mode2_{noteName}_{noteIndex}_NoteOffDelayedEventKey"];

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
                        object key = this[$"Mode2_{noteName}_{noteIndex}_NoteOffDoubleClickEventKey"];

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
                    object key = this[$"Mode2_{noteName}_{noteIndex}_NoteOffEventKey"];

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

        private void ControlChangedMode2(MidiMessageRecievedEventArgs e)
        {
            SetMode(2);

            if (e.Message.Data1 > 50 && e.Message.Data1 < 59) // Top Row Fader Buttons
            {
                if (e.Message.Data2 == 127) // Pressed
                {
                    object[] keys = new object[] {
                      Mode2FaderButton1PressedEventKey,
                      Mode2FaderButton2PressedEventKey,
                      Mode2FaderButton3PressedEventKey,
                      Mode2FaderButton4PressedEventKey,
                      Mode2FaderButton5PressedEventKey,
                      Mode2FaderButton6PressedEventKey,
                      Mode2FaderButton7PressedEventKey,
                      Mode2FaderButton8PressedEventKey,
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
                      Mode2FaderButton1ReleasedEventKey,
                      Mode2FaderButton2ReleasedEventKey,
                      Mode2FaderButton3ReleasedEventKey,
                      Mode2FaderButton4ReleasedEventKey,
                      Mode2FaderButton5ReleasedEventKey,
                      Mode2FaderButton6ReleasedEventKey,
                      Mode2FaderButton7ReleasedEventKey,
                      Mode2FaderButton8ReleasedEventKey,
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
                      Mode2FaderButton9PressedEventKey,
                      Mode2FaderButton10PressedEventKey,
                      Mode2FaderButton11PressedEventKey,
                      Mode2FaderButton12PressedEventKey,
                      Mode2FaderButton13PressedEventKey,
                      Mode2FaderButton14PressedEventKey,
                      Mode2FaderButton15PressedEventKey,
                      Mode2FaderButton16PressedEventKey,
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
                      Mode2FaderButton9ReleasedEventKey,
                      Mode2FaderButton10ReleasedEventKey,
                      Mode2FaderButton11ReleasedEventKey,
                      Mode2FaderButton12ReleasedEventKey,
                      Mode2FaderButton13ReleasedEventKey,
                      Mode2FaderButton14ReleasedEventKey,
                      Mode2FaderButton15ReleasedEventKey,
                      Mode2FaderButton16ReleasedEventKey,
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
                      Mode2SlideFader1ChangedEventKey,
                      Mode2SlideFader2ChangedEventKey,
                      Mode2SlideFader3ChangedEventKey,
                      Mode2SlideFader4ChangedEventKey,
                      Mode2SlideFader5ChangedEventKey,
                      Mode2SlideFader6ChangedEventKey,
                      Mode2SlideFader7ChangedEventKey,
                      Mode2SlideFader8ChangedEventKey,
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
                      Mode2KnobFader1ChangedEventKey,
                      Mode2KnobFader2ChangedEventKey,
                      Mode2KnobFader3ChangedEventKey,
                      Mode2KnobFader4ChangedEventKey,
                      Mode2KnobFader5ChangedEventKey,
                      Mode2KnobFader6ChangedEventKey,
                      Mode2KnobFader7ChangedEventKey,
                      Mode2KnobFader8ChangedEventKey,
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

                object key = Mode2ModulationBendEventKey;

                ((EventHandler<OnModulationBendEventArgs>)listEventDelegates[key])?.Invoke(this, new OnModulationBendEventArgs()
                {
                    DeviceName = "Novation SL MK3",
                    ModulationBendValue = modvolume,
                });
            }
        }

        private void PitchWheelChangedMode2(MidiMessageRecievedEventArgs e)
        {
            SetMode(2);

            int pitchinter = e.Message.Data1;
            int pitchvalue = e.Message.Data2;

            object key = Mode2PitchBendEventKey;

            ((EventHandler<OnPitchBendEventArgs>)listEventDelegates[key])?.Invoke(this, new OnPitchBendEventArgs()
            {
                DeviceName = "Novation SL MK3",
                PitchBendValue = pitchvalue,
            });
        }
    }
}
