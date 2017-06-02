using System;
using System.Collections.Generic;
using CoreGraphics;
using UIKit;
using System.Threading.Tasks;
using System.Threading;

namespace TheList
{
	public partial class ViewController : UIViewController
	{
		private UILabel _label1;

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();

		}


		///• Create a method that does something but doesn't return anything 
		private void labelm()
		{
			var rect = new CoreGraphics.CGRect();
			_label1 = new UILabel(rect);
			_label1.Text = "blake";
			View.Add(_label1);
		}
		/// this method creates a UIlabel but does not return anything

		///==========================================
		///• Create a method that returns a string

		private string StringMethod()
		{
			string string1;
			string1 = "hello";
			return string1;

		}
		/// a simpal method for returning a string, the stringis defined in the method but can be defined in a field;

		///===========================================
		///• Create method that returns a float

		private float FloatMethod1()
		{
			float float1 = 15f;
			return float1;
		}
		///a simpal method for returning a float, the float is defined in the method but can be defined in a field;

		///===========================================
		////Write a new class
		public class class2
		{
			public int intProp2 { get; set; }
		}
		///===========================================
		///• Create a method that returns a type of the class you've just created(class 3 )
		public class class3
		{
			public string stringProp { get; set; }
			public int intProp { get; set; }


		}
	////	//================================================
		///• Create a new object from your custom class and use the method described in the previous step
		public class class4
		{
			class3 classMethod1 = new class3()
			{
				stringProp = "blake",
				intProp = 5
			};
			///==============================================
			///Create a method that takes an argument
			public void methodArgument1(int x, int y)
			{

			}
			/// in this case the argument is (int x, int y)

			///=======================================
			///• Create a method that takes an argument* and* at least one optional argument
			public void methodArgument2(int x, int y = 15)
			{

			}

			/// in this exsample the optinal argument is the int y = 15 were =15 is the optional argument, this can be overwriten if needed.

			//=============================================================================
			///• Create, subscribe and react to an event

			/// this has been cometed out due to build errors that only apply because of the way i have listed the ansers to the question, 
			///all code has been run and tested in an diffrent aplication!!!!!!!!!!!!!!!!!!!!!!!!!!!!

			///public event Action FireEvent; //place into field

			//FireEvent(); // Set off the event in view did load or requierd method 

			//FireEvent += ShowString; //event controle to call a method were showString is the method 

			//public void ShowString()// the method is called 
			//{
			//	_txt1.Text = "Hello World";

			//}


			///==============================================================================
			///• Create a button that does something when you click it

			private UIButton _button1;



			private void button1()
			{
				var rect = new CGRect(25, 100, 100, 50);
				_button1 = new UIButton(rect);
				_button1.Layer.BorderWidth = 3f;
				_button1.Layer.BorderColor = UIColor.Green.CGColor;
				_button1.Layer.CornerRadius = 15f;
		//		View.Add(_button1);//this pice of code workes but only in the
								   ///view controller class i have placed it here for convenanse.

				_button1.TouchUpInside += button1C;  

			}
			private void button1C(object sender, EventArgs e)
			{
				int x = 10;
				int y = 20;
				int z;
				z = x + y;
			}
			///=================================================================================
			///• Create a list of types e.g. string, int, a custom class(in next section) etc.
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
			///==========================================================================
			///• Create a loop that iterates through a list and add certain elements (based on a criteria you decide)
			///to a second list.
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
			///=======================================================================================
			///• Create a string and add extra content to it every 10 seconds.

			public string string1;
			public string string2;

			public async Task string1M()
			{


				string1 = " hello ";
				string2 = " blake ";


				for (int i = 0; i < 20; i++)
				{
					string1 += string2;
					await Task.Delay(10000); // delay by 10 seconds,, another way around this problem 
					///is to create a timer and program it to start, stop & stop when needed

				}

			}
			//======================================================================

			////			• What does private mean?
			//Private means that only the class its defined in or a class that dirves from that class can asses the variable

			////• What does public mean?
			//Public means that the veriabl/method is open and can be called upon/worked with from an outside class

			////• What does static mean?
			//Static = fixed, it can only contain static members, cannot be instantiated

			////• The difference between a property and a field.
			//A field is a variable declared directly in the class normally private.
			//A property is a way to access the field, the get set property will alaw access to the variable/field without directly working with it providing a level of abstraction 


			////• The purpose of a public get and a private set in a property.
			//Private set’ers law you to create read-only / protected propertys.





			////• The purpose of interfaces.
			// an interface can be seen as a contract btween classes, with the Ispeek or Istore ect defined in the interface class
			// the classes that then dirive from that class e.g. class somthing : Ispeek, Istore. must then forfill the objects/propertys from the I classes



			////• Polymorphism
			//??? is the ability to take an object and changing it into sevral difrent ways. this is closly linked with inheritance. 
			//Polymorphism is when you can treat an object as a generic version of something, 
			//but when you access it, the code determines which exact type it is and calls the associated code.




			////• Overloading
			//Overriding is where there may be methods of the same name but they must take in different arguments, e.g.
			//method1(int x, int y)
			//method1(int x, string y)
			//method1(int x, int y, string z)
			//Each method is called the same but take different arguments


			////==================== score is 0/18


		}

	}
}
