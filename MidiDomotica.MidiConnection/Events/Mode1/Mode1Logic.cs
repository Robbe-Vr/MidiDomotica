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
        private void onTimerElapsedMode1(object sender, ElapsedEventArgs e)
        {
            if (timer != null && timer.Enabled)
            {
                timer.Stop();
            }

            var lastNote = notePressHistory.LastOrDefault();

            if (lastNote != null)
            {
                object key = this[$"Mode1_{lastNote.Note}_{lastNote.NoteIndex}_NoteHeldEventKey"];

                if (key != null)
                {
                    ((EventHandler<OnNoteHoldEventArgs>)listEventDelegates[key])?.Invoke(this, new OnNoteHoldEventArgs()
                    {
                        NoteIndex = lastNote.NoteIndex,
                        Note = lastNote.Note,
                        Intensity = lastNote.Intensity,
                        DeviceName = "Novation SL MK3",
                    });
                }
            }

            if (timer != null && repeating)
            {
                timer.Start();
            }
        }

        public void NotePressedMode1(MidiMessageRecievedEventArgs e)
        {
            SetMode(1);

            DateTime timeNow = DateTime.Now;

            timer = new Timer(MsForHold);
            timer.Elapsed += onTimerElapsedMode1;
            timer.AutoReset = false;
            timer.Start();

            var lastNote = notePressHistory.LastOrDefault(n => n.NoteIndex == e.Message.Data1);

            int noteIndex = e.Message.Data1;
            string noteName = NoteForIndex(noteIndex).ToString();

            if (lastNote != null && timeNow.Subtract(lastNote.TimeStamp).TotalMilliseconds < MsForDoubleClick)
            {
                object key = this[$"Mode1_{noteName}_{noteIndex}_NoteOnDoubleClickEventKey"];

                if (key != null)
                {
                    ((EventHandler<OnNoteOnEventArgs>)listEventDelegates[key])?.Invoke(this, new OnNoteOnEventArgs()
                    {
                        DeviceName = "Novation SL MK3",
                        Note = noteName,
                        NoteIndex = noteIndex,
                        Intensity = e.Message.Data2,
                    });
                }
            }
            else
            {
                object key = this[$"Mode1_{noteName}_{noteIndex}_NoteOnEventKey"];

                if (key != null)
                {
                    ((EventHandler<OnNoteOnEventArgs>)listEventDelegates[key])?.Invoke(this, new OnNoteOnEventArgs()
                    {
                        DeviceName = "Novation SL MK3",
                        NoteIndex = noteIndex,
                        Note = noteName,
                        Intensity = e.Message.Data2,
                    });
                }
            }

            notePressHistory.Add(new NotePressedData()
            {
                NoteIndex = noteIndex,
                Note = noteName,
                Intensity = e.Message.Data2,
                TimeStamp = DateTime.Now,
            });
        }

        private void NoteReleasedMode1(MidiMessageRecievedEventArgs e)
        {
            SetMode(1);

            var timeNow = DateTime.Now;
            var lastNote = notePressHistory.LastOrDefault(n => n.NoteIndex == e.Message.Data1);
            var timeHeld = lastNote != null ? timeNow.Subtract(lastNote.TimeStamp) : TimeSpan.MinValue;

            int noteIndex = e.Message.Data1;
            string noteName = NoteForIndex(noteIndex).ToString();

            if (timeHeld.TotalMilliseconds > MsForHold)
            {
                object key = this[$"Mode1_{noteName}_{noteIndex}_NoteOffDelayedEventKey"];

                if (key != null)
                {
                    ((EventHandler<OnNoteOffDelayedEventArgs>)listEventDelegates[key])?.Invoke(this, new OnNoteOffDelayedEventArgs()
                    {
                        DeviceName = "Novation SL MK3",
                        NoteIndex = noteIndex,
                        Note = noteName,
                        TimeHeld = timeHeld,
                    });
                }
            }
            else
            {
                NotePressedData note = noteReleaseHistory.LastOrDefault(n => n.NoteIndex == e.Message.Data1);

                if (note != null && (timeNow - note.TimeStamp).TotalMilliseconds < MsForDoubleClick)
                {
                    object key = this[$"Mode1_{noteName}_{noteIndex}_NoteOffDoubleClickEventKey"];

                    if (key != null)
                    {
                        ((EventHandler<OnNoteOffEventArgs>)listEventDelegates[key])?.Invoke(this, new OnNoteOffEventArgs()
                        {
                            DeviceName = "Novation SL MK3",
                            Note = noteName,
                            NoteIndex = noteIndex,
                            TimeHeld = timeHeld,
                        });
                    }
                }
                else
                {
                    object key = this[$"Mode1_{noteName}_{noteIndex}_NoteOffEventKey"];

                    if (key != null)
                    {
                        ((EventHandler<OnNoteOffEventArgs>)listEventDelegates[key])?.Invoke(this, new OnNoteOffEventArgs()
                        {
                            DeviceName = "Novation SL MK3",
                            NoteIndex = noteIndex,
                            Note = noteName,
                            TimeHeld = timeHeld,
                        });
                    }
                }

                if (timer != null)
                {
                    timer.Stop();
                    timer.Dispose();
                    timer = null;
                }
            }

            noteReleaseHistory.Add(new NotePressedData()
            {
                NoteIndex = e.Message.Data1,
                Note = NoteForIndex(e.Message.Data1).ToString(),
                Intensity = e.Message.Data2,
                TimeStamp = DateTime.Now,
            });
        }

        private void ControlChangedMode1(MidiMessageRecievedEventArgs e)
        {
            SetMode(1);

            if (e.Message.Data1 > 50 && e.Message.Data1 < 59) // Top Row Fader Buttons
            {
                if (e.Message.Data2 == 127) // Pressed
                {
                    object[] keys = new object[] {
                      Mode1FaderButton1PressedEventKey,
                      Mode1FaderButton2PressedEventKey,
                      Mode1FaderButton3PressedEventKey,
                      Mode1FaderButton4PressedEventKey,
                      Mode1FaderButton5PressedEventKey,
                      Mode1FaderButton6PressedEventKey,
                      Mode1FaderButton7PressedEventKey,
                      Mode1FaderButton8PressedEventKey,
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
                      Mode1FaderButton1ReleasedEventKey,
                      Mode1FaderButton2ReleasedEventKey,
                      Mode1FaderButton3ReleasedEventKey,
                      Mode1FaderButton4ReleasedEventKey,
                      Mode1FaderButton5ReleasedEventKey,
                      Mode1FaderButton6ReleasedEventKey,
                      Mode1FaderButton7ReleasedEventKey,
                      Mode1FaderButton8ReleasedEventKey,
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
                      Mode1FaderButton9PressedEventKey,
                      Mode1FaderButton10PressedEventKey,
                      Mode1FaderButton11PressedEventKey,
                      Mode1FaderButton12PressedEventKey,
                      Mode1FaderButton13PressedEventKey,
                      Mode1FaderButton14PressedEventKey,
                      Mode1FaderButton15PressedEventKey,
                      Mode1FaderButton16PressedEventKey,
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
                      Mode1FaderButton9ReleasedEventKey,
                      Mode1FaderButton10ReleasedEventKey,
                      Mode1FaderButton11ReleasedEventKey,
                      Mode1FaderButton12ReleasedEventKey,
                      Mode1FaderButton13ReleasedEventKey,
                      Mode1FaderButton14ReleasedEventKey,
                      Mode1FaderButton15ReleasedEventKey,
                      Mode1FaderButton16ReleasedEventKey,
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
                      Mode1SlideFader1ChangedEventKey,
                      Mode1SlideFader2ChangedEventKey,
                      Mode1SlideFader3ChangedEventKey,
                      Mode1SlideFader4ChangedEventKey,
                      Mode1SlideFader5ChangedEventKey,
                      Mode1SlideFader6ChangedEventKey,
                      Mode1SlideFader7ChangedEventKey,
                      Mode1SlideFader8ChangedEventKey,
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
                      Mode1KnobFader1ChangedEventKey,
                      Mode1KnobFader2ChangedEventKey,
                      Mode1KnobFader3ChangedEventKey,
                      Mode1KnobFader4ChangedEventKey,
                      Mode1KnobFader5ChangedEventKey,
                      Mode1KnobFader6ChangedEventKey,
                      Mode1KnobFader7ChangedEventKey,
                      Mode1KnobFader8ChangedEventKey,
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

                object key = Mode1ModulationBendEventKey;

                ((EventHandler<OnModulationBendEventArgs>)listEventDelegates[key])?.Invoke(this, new OnModulationBendEventArgs()
                {
                    DeviceName = "Novation SL MK3",
                    ModulationBendValue = modvolume,
                });
            }
        }

        private void PitchWheelChangedMode1(MidiMessageRecievedEventArgs e)
        {
            SetMode(1);

            int pitchinter = e.Message.Data1;
            int pitchvalue = e.Message.Data2;

            object key = Mode1PitchBendEventKey;

            ((EventHandler<OnPitchBendEventArgs>)listEventDelegates[key])?.Invoke(this, new OnPitchBendEventArgs()
            {
                DeviceName = "Novation SL MK3",
                PitchBendValue = pitchvalue,
            });
        }
    }
}
