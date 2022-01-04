using Q42.HueApi.ColorConverters;
using Q42.HueApi.Streaming.Effects;
using Q42.HueApi.Streaming.Extensions;
using Q42.HueApi.Streaming.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MidiDomotica.Remote.Hue.Entertainment
{
    internal partial class HueEntertainmentHandler
    {
        public void RunExample()
        {
            if (EntertainmentBusy) return;

            entertainmentTaskCancellationTokenSource = new CancellationTokenSource();

            runningTask = Task.Run(async () =>
            {
                await Init();

                if (stream == null)
                {
                    Trace.WriteLine("Not executing example, error connecting to bridge!");
                    return;
                }

                baseEntLayer = stream.GetNewLayer(isBaseLayer: true);
                effectLayer = stream.GetNewLayer();

                baseEntLayer.AutoCalculateEffectUpdate(new CancellationToken());
                effectLayer.AutoCalculateEffectUpdate(new CancellationToken());

                var orderedLeft = baseEntLayer.GetLeft().OrderByDescending(x => x.LightLocation.Y).ThenBy(x => x.LightLocation.X).To2DGroup();
                var orderedRight = baseEntLayer.GetRight().OrderByDescending(x => x.LightLocation.Y).ThenByDescending(x => x.LightLocation.X);
                var allLightsOrdered = baseEntLayer.OrderBy(x => x.LightLocation.X).ThenBy(x => x.LightLocation.Y).ToList().To2DGroup();
                var allLightsOrderedFlat = baseEntLayer.OrderBy(x => x.LightLocation.X).ThenBy(x => x.LightLocation.Y).ToList();
                var orderedByDistance = baseEntLayer.OrderBy(x => x.LightLocation.Distance(0, 0, 0)).To2DGroup();
                var orderedByAngle = baseEntLayer.OrderBy(x => x.LightLocation.Angle(0, 0)).To2DGroup();
                var line1 = baseEntLayer.Where(x => x.LightLocation.X <= -0.6).ToList();
                var line2 = baseEntLayer.Where(x => x.LightLocation.X > -0.6 && x.LightLocation.X <= -0.1).ToList();
                var line3 = baseEntLayer.Where(x => x.LightLocation.X > -0.1 && x.LightLocation.X <= 0.1).ToList();
                var line4 = baseEntLayer.Where(x => x.LightLocation.X > 0.1 && x.LightLocation.X <= 0.6).ToList();
                var line5 = baseEntLayer.Where(x => x.LightLocation.X > 0.6).ToList();

                var allLightsReverse = allLightsOrdered.ToList();
                allLightsReverse.Reverse();

                CancellationTokenSource cst = new CancellationTokenSource();

                var quarter = new[] { baseEntLayer.GetLeft().GetFront(), baseEntLayer.GetLeft().GetBack(), baseEntLayer.GetRight().GetBack(), baseEntLayer.GetRight().GetFront() }.ToList();

                baseEntLayer.SetState(cst.Token, new RGBColor("FFFFFF"), 1);
                cst = WaitCancelAndNext(cst, 5);

                Console.WriteLine("Transition to red in 10 seconds");
                baseEntLayer.SetState(cst.Token, new RGBColor("FF0000"), TimeSpan.FromSeconds(10));
                Thread.Sleep(12000);

                Console.WriteLine("Transition to bri 0.25");
                baseEntLayer.SetState(cst.Token, null, default, 0.25 * HueEntertainmentCommands.brightnessCeiling, TimeSpan.FromSeconds(1), true);
                Thread.Sleep(2000);

                Console.WriteLine("Transition to bri 1");
                baseEntLayer.SetState(cst.Token, new RGBColor("0000FF"), TimeSpan.FromSeconds(5), 1 * HueEntertainmentCommands.brightnessCeiling, TimeSpan.FromSeconds(1), false);

                cst = WaitCancelAndNext(cst, 2);
                Console.WriteLine("Random color All / All");
                quarter.SetRandomColor(cst.Token, IteratorEffectMode.All, IteratorEffectMode.All, waitTime: () => TimeSpan.FromMilliseconds(500));
                cst = WaitCancelAndNext(cst, 5);


                Console.WriteLine("Flash on lights Cycle / Random");
                quarter.FlashQuick(cst.Token, new Q42.HueApi.ColorConverters.RGBColor("FFFFFF"), IteratorEffectMode.Cycle, IteratorEffectMode.Random, waitTime: () => TimeSpan.FromMilliseconds(50));
                cst = WaitCancelAndNext(cst, 5);

                Console.WriteLine("SetColor white Single / Single");
                quarter.SetColor(cst.Token, new RGBColor("FFFFFF"), IteratorEffectMode.Single, IteratorEffectMode.Single, waitTime: () => TimeSpan.FromMilliseconds(200));
                cst = WaitCancelAndNext(cst, 3);


                Console.WriteLine("Flash on lights Cycle / All");
                quarter.FlashQuick(cst.Token, new Q42.HueApi.ColorConverters.RGBColor("FFFFFF"), IteratorEffectMode.Cycle, IteratorEffectMode.All, waitTime: () => TimeSpan.FromMilliseconds(50));
                cst = WaitCancelAndNext(cst, 3);

                Console.WriteLine("Flash on lights Cycle / Single");
                quarter.FlashQuick(cst.Token, new Q42.HueApi.ColorConverters.RGBColor("FFFFFF"), IteratorEffectMode.Cycle, IteratorEffectMode.Single, waitTime: () => TimeSpan.FromMilliseconds(50));
                cst = WaitCancelAndNext(cst, 3);

                Console.WriteLine("Random color Cycle / All");
                quarter.SetRandomColor(cst.Token, IteratorEffectMode.Cycle, IteratorEffectMode.All, waitTime: () => TimeSpan.FromMilliseconds(500));
                cst = WaitCancelAndNext(cst, 3);

                Console.WriteLine("Random color Cycle / AllIndividual");
                quarter.SetRandomColor(cst.Token, IteratorEffectMode.Cycle, IteratorEffectMode.AllIndividual, waitTime: () => TimeSpan.FromMilliseconds(500));
                cst = WaitCancelAndNext(cst, 3);

                Console.WriteLine("Random color Cycle / Single");
                quarter.SetRandomColor(cst.Token, IteratorEffectMode.Cycle, IteratorEffectMode.Single, waitTime: () => TimeSpan.FromMilliseconds(500));
                cst = WaitCancelAndNext(cst, 3);

                Console.WriteLine("Random color Cycle / Random");
                quarter.SetRandomColor(cst.Token, IteratorEffectMode.Cycle, IteratorEffectMode.Random, waitTime: () => TimeSpan.FromMilliseconds(500));
                cst = WaitCancelAndNext(cst, 3);

                Console.WriteLine("Random color Cycle / Bounce");
                quarter.SetRandomColor(cst.Token, IteratorEffectMode.Cycle, IteratorEffectMode.Bounce, waitTime: () => TimeSpan.FromMilliseconds(500));
                cst = WaitCancelAndNext(cst, 3);


                Console.WriteLine("Random color on all lights");
                baseEntLayer.To2DGroup().SetRandomColor(cst.Token, IteratorEffectMode.All, waitTime: () => TimeSpan.FromMilliseconds(500));
                cst = WaitCancelAndNext(cst, 3);

                //Random color from center
                Console.WriteLine("Fill white color from center");
                await orderedByDistance.SetColor(cst.Token, new RGBColor("FFFFFF"), IteratorEffectMode.Single, waitTime: () => TimeSpan.FromMilliseconds(50));
                cst = WaitCancelAndNext(cst, 5);

                //Random color from center
                Console.WriteLine("Fill red color order by angle from center");
                await orderedByAngle.SetColor(cst.Token, new RGBColor("FF0000"), IteratorEffectMode.Single, waitTime: () => TimeSpan.FromMilliseconds(50));
                cst = WaitCancelAndNext(cst, 5);

                Console.WriteLine("A pulse of random color is placed on an XY grid, matching your entertainment setup");
                var randomPulseEffect = new RandomPulseEffect();
                baseEntLayer.PlaceEffect(randomPulseEffect);
                randomPulseEffect.Start();

                cst = WaitCancelAndNext(cst, 3);
                randomPulseEffect.Stop();

                Console.WriteLine("A pulse of random color is placed on an XY grid, matching your entertainment setup");
                var randomPulseEffectNoFade = new RandomPulseEffect(false);
                baseEntLayer.PlaceEffect(randomPulseEffectNoFade);
                randomPulseEffectNoFade.Start();

                cst = WaitCancelAndNext(cst, 3);
                randomPulseEffectNoFade.Stop();


                Console.WriteLine("Different random colors on all lights");
                baseEntLayer.To2DGroup().SetRandomColor(cst.Token, IteratorEffectMode.AllIndividual, waitTime: () => TimeSpan.FromMilliseconds(500));
                cst = WaitCancelAndNext(cst, 3);


                Console.WriteLine("Trailing light effect with transition times");
                allLightsOrdered.Flash(cst.Token, new Q42.HueApi.ColorConverters.RGBColor("FF0000"), IteratorEffectMode.Cycle, waitTime: () => TimeSpan.FromMilliseconds(500), transitionTimeOn: () => TimeSpan.FromMilliseconds(1000), transitionTimeOff: () => TimeSpan.FromMilliseconds(1000), waitTillFinished: false);
                cst = WaitCancelAndNext(cst, 5);

                Console.WriteLine("Knight rider (works best with 6+ lights)");
                allLightsOrdered.KnightRider(cst.Token);
                cst = WaitCancelAndNext(cst, 4);

                Ref<TimeSpan> waitTime = TimeSpan.FromMilliseconds(750);

                Console.WriteLine("Flash lights (750ms), press enter to decrease by 200 ms");
                allLightsOrdered.FlashQuick(cst.Token, new Q42.HueApi.ColorConverters.RGBColor("FFFFFF"), IteratorEffectMode.Cycle, waitTime: () => waitTime);
                Thread.Sleep(1000);

                waitTime.Value -= TimeSpan.FromMilliseconds(200);
                Console.WriteLine($"Flash ({waitTime.Value.TotalMilliseconds})");
                Thread.Sleep(1000);

                waitTime.Value -= TimeSpan.FromMilliseconds(200);
                Console.WriteLine($"Flash ({waitTime.Value.TotalMilliseconds})");
                Thread.Sleep(1000);

                waitTime.Value -= TimeSpan.FromMilliseconds(200);
                Console.WriteLine($"Flash ({waitTime.Value.TotalMilliseconds})");
                Thread.Sleep(1000);

                waitTime.Value -= TimeSpan.FromMilliseconds(100);
                Console.WriteLine($"Flash ({waitTime.Value.TotalMilliseconds})");
                cst = WaitCancelAndNext(cst, 1);

                Console.WriteLine("Flash on random lights");
                allLightsOrdered.FlashQuick(cst.Token, new Q42.HueApi.ColorConverters.RGBColor("FFFFFF"), IteratorEffectMode.Random, waitTime: () => waitTime);
                cst = WaitCancelAndNext(cst, 3);

                Console.WriteLine("Flash on ALL lights");
                waitTime.Value = TimeSpan.FromMilliseconds(150);
                allLightsOrdered.Flash(cst.Token, new Q42.HueApi.ColorConverters.RGBColor("FFFFFF"), IteratorEffectMode.All, waitTime: () => waitTime);
                cst = WaitCancelAndNext(cst, 3);

                Console.WriteLine("Flash effect with transition times");
                baseEntLayer.GetLeft().To2DGroup().Flash(cst.Token, new Q42.HueApi.ColorConverters.RGBColor("FF0000"), IteratorEffectMode.All, waitTime: () => TimeSpan.FromSeconds(1), transitionTimeOn: () => TimeSpan.FromMilliseconds(1000), transitionTimeOff: () => TimeSpan.FromMilliseconds(1000));
                await Task.Delay(2000);
                baseEntLayer.GetRight().To2DGroup().Flash(cst.Token, new Q42.HueApi.ColorConverters.RGBColor("FF0000"), IteratorEffectMode.All, waitTime: () => TimeSpan.FromSeconds(1), transitionTimeOn: () => TimeSpan.FromMilliseconds(1000), transitionTimeOff: () => TimeSpan.FromMilliseconds(1000));
                cst = WaitCancelAndNext(cst, 3);


                Console.WriteLine("A red light that is moving in vertical direction and is placed on an XY grid, matching your entertainment setup");
                var redLightEffect = new RedLightEffect();
                redLightEffect.Radius = 0.7;
                redLightEffect.Y = -0.8;
                redLightEffect.X = -0.8;
                baseEntLayer.PlaceEffect(redLightEffect);
                redLightEffect.Start();

                Task.Run(async () =>
                {
                    double step = 0.2;
                    while (true)
                    {
                        redLightEffect.Y += step;
                        await Task.Delay(100);
                        if (redLightEffect.Y >= 2)
                            step = -0.1;
                        if (redLightEffect.Y <= -2)
                            step = +0.1;
                    }
                }, cst.Token);


                cst = WaitCancelAndNext(cst, 10);
                redLightEffect.Stop();

                Console.WriteLine("Thank you for using Q42.Hue.Streaming. This library was developed during Christmas 2017.");

                baseEntLayer.SetState(cst.Token, new RGBColor("FFFFFF"), 1 * HueEntertainmentCommands.brightnessCeiling);
            }, entertainmentTaskCancellationTokenSource.Token);
        }

        private static CancellationTokenSource WaitCancelAndNext(CancellationTokenSource cst, int seconds)
        {
            Thread.Sleep(seconds * 1000);
            cst.Cancel();
            cst = new CancellationTokenSource();
            return cst;
        }
    }
}
