using System;
using System.Collections.Generic;
using CoreGraphics;
using UIKit;
using System.Threading.Tasks;

namespace TheList
{
	public partial class ViewController : UIViewController
	{
		private UILabel _label1;

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();

		}


		//• Create a method that does something but doesn't return anything 
		private void labelm()
		{
			var rect = new CoreGraphics.CGRect();
			_label1 = new UILabel(rect);
			_label1.Text = "blake";
			View.Add(_label1);
		}
		//==========================================
		//• Create a method that returns a string

		private string StringMethod()
		{
			string string1;
			string1 = "hello";
			return string1;

		}
		//===========================================
		//• Create method that returns a float

		private float StringMethod1()
		{
			float float1 = 15f;
			return float1;
		}
		//===========================================
		//Write a new class
		public class class2
		{
			public int intProp2 { get; set; }
		}
		//===========================================
		//• Create a method that returns a type of the class you've just created
		public class class3
		{
			public string stringProp { get; set; }
			public int intProp { get; set; }


		}
		//================================================
		//• Create a new object from your custom class and use the method described in the previous step
		public class class4
		{
			class3 classMethod1 = new class3()
			{
				stringProp = "blake",
				intProp = 5
			};
			//==============================================
			//Create a method that takes an argument
			public void methodArgument1(int x, int y)
			{

			}
			//=======================================
			//• Create a method that takes an argument* and* at least one optional argument
			public void methodArgument2(int x, int y = 15)
			{

			}
			//=============================================================================
			//• Create, subscribe and react to an event



			//==============================================================================
			//• Create a button that does something when you click it

			private UIButton _button1;

		//	_button1.TouchUpInside += buttonC;

			private void button1()
			{
				var rect = new CGRect(25, 100, 100, 50);
				_button1 = new UIButton(rect);
				_button1.Layer.BorderWidth = 3f;
				_button1.Layer.BorderColor = UIColor.Green.CGColor;
				_button1.Layer.CornerRadius = 15f;
	//			View.Add(_button1);//this pice of code workes but only in the
								   //view controller class i have placed it here for convenanse.

			}
			private void button1C(object sender, EventArgs e)
			{
				int x = 10;
				int y = 20;
				int z;
				z = x + y;
			}
			//=================================================================================
			//• Create a list of types e.g. string, int, a custom class(in next section) etc.
			public void NewList()
			{
				List<int> list1 = new List<int>();

				list1.Add(1);
				list1.Add(2);
				list1.Add(3);
				//--------------------------
				List<string> list2 = new List<string>();
				list2.Add("jhon");
				list2.Add("jordan");
				list2.Add("blake");
				//--------------------------


				class2 class2IN = new class2();

				List<class2> list3 = new List<class2>()
				{
				class2IN
				};

			}
			//==========================================================================
			//• Create a loop that iterates through a list and add certain elements (based on a criteria you decide)
			//to a second list.
			public int _intLoop;

			public void listLoop()
			{

				List<int> list4 = new List<int>();
				list4.Add(1);
				list4.Add(2);
				list4.Add(3);

				List<int> list5 = new List<int>();
				list5.Add(1);
				list5.Add(3);
				list5.Add(4);

				foreach (int int1 in list4)
				{
					_intLoop = int1;

					if (_intLoop == 2)
					{
						list5.Add(2);
					}
				}

			}
		}

	}
}
