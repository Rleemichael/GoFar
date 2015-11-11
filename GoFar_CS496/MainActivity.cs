//=============EYE BREAK======================
//------------Pseuodocode---------------------
//start counter for eye break
//after x seconds
//trigger eye break reminder
//popup new screen with eye break information	
//user needs to tap button to stop notification (vibrate/noise)

//===============MOVEMENT BREAK===============
//------------Pseudocode-----------------------
//start counter for movement break
//after y seconds
//trigger movement break reminder
//popup new screen with movement information
//waiter for either
//user passes because they can't take a break at that time
//reset timer and start again
//app detects some walking movement through accelerometer from user
//reset timer and start againr

//=============================================
//TESTING Changes
//=============================================

using System;
using System.Timers;

using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Android.Hardware;

namespace GoFar_CS496
{
	[Activity (Label = "GoFar_CS496", MainLauncher = true, Icon = "@drawable/icon")]
	public class MainActivity : Activity, ISensorEventListener
	{

		protected override void OnCreate (Bundle bundle)
		{
			
			int eyeIntervalTime = 1000;
			int moveIntervalTime = 2000;

			base.OnCreate (bundle);

			// Set our view from the "main" layout resource
			SetContentView (Resource.Layout.Main);

			// Get our button from the layout resource,
			// and attach an event to it
			Button button = FindViewById<Button> (Resource.Id.myButton);
			
			button.Click += delegate {
				button.Text = string.Format ("{0} clicks!", count++);
			};


			//TODO: Call timer method for eye break and pass time parameter (eyeIntervalTime)

			//TODO: Call timer method for movement break and pass time parameter (moveIntervalTime)
			//need two timers because timer resets after each event


		}

		//possible extension - start timers based on GPS coordinates (e.g. work location)?
		//possible extension - start timers based calendar (e.g. work week)?
		//possible extension - count and store steps to track against 10k per day recommendation


		//possible upgrade - use single timer?

		//=============METHODS============================
		//timer method, System.Timer() runs in milliseconds
		void timer(int intervalTime)
		{
			//create new timer object and set interval to passed parameter
			breakTimer = new Timer();
			breakTimer.Interval = intervalTime;

			//start timer
			breakTimer.Enabled = true;

			//eye break
			if (intervalTime == 1000)
			{
				breakTimer.Elapsed+= new ElapsedEventHandler(eyeBreak);
			}

			//movement break
			if(intervalTime == 2000)
			{
				breakTimer.Elapsed+= new ElapsedEventHandler(movementBreak);
			}

			//resets timer after event has occured
			breakTimer.AutoReset = true;
			//Use this to keep timer alive for long running methods such as this to prevent garbage collection from destroying
			GC.KeepAlive (breakTimer);
		}


		   


		//eye break popup method
		private static void eyeBreak(ElapsedEventArgs e)
		{
			//TODO
		}

		//movement break popup method
		private static void movementBreak(ElapsedEventArgs e)
		{
			//TODO
		}








	}
}


