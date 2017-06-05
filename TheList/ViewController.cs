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
		/// Nice, this is good. Also think about void methods which add 2 ints or strings together or display a message
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
		/// Spot on, he will ask you to make this run, so it's a case of random.Text = StringMethod();

		private string StringMethod()
		{
			string string1;
			string1 = "hello";
			return string1;
		}
		/// a simpal method for returning a string, the stringis defined in the method but can be defined in a field;

		///===========================================
		///• Create method that returns a float
		/// Spot on, as the string method above he will ask you to display this too.

		private float FloatMethod1()
		{
			float float1 = 15f;
			return float1;
		}
		///a simpal method for returning a float, the float is defined in the method but can be defined in a field;

		///===========================================
		////Write a new class
		/// Nice, good work.
		public class class2
		{
			public int intProp2 { get; set; }

		}

		///===========================================
		///• Create a method that returns a type of the class you've just created(class 3 )
		/// 

		/// The questions asking you to create a method that returns a type of the class you made
		/// so for example a method such as "public class2 ReturnClass2() { input code and return value}"
		/// What you could do for the method set the intProp2 within it.
		/// Then within class3 make a method.
		/// 
		/// Below I have given some code that will help you get started on making a method elsewhere.
		public class class3
		{
			public string stringProp { get; set; }
			public int intProp { get; set; }
		}
		//-----------------------
		//Use this method and it returns a custom type of the class you made
		//Breakpoint the return line and you will see it has worked.
		//public class2 ReturnClass2()
		//{
		//	class2 C2 = new class2();

		//	C2.intProp2 = 160;
		//	return C2;
		//}

		////	//================================================
		///• Create a new object from your custom class and use the method described in the previous step
		///  Due to not having made a method in the previous step you haven't been able to fully finish this task.
		/// But you have created an object so that's good.
		/// //Use the object to call the method so example.Text = classMethod.ReturnClass2(); though this would be awkward due to displaying 
		/// class method return values as it can be a dick. Think of using a foreach loop after having it added to a list as they are great in showing class elements.
		/// Or even better just show the intprop value has changed from the method i did before
		public class class4
		{
			class3 classMethod1 = new class3()
			{
				stringProp = "blake",
				intProp = 5
			};

			//I would suggeast making a list loop to display the items from your object. It's what i did with Alex.
			//We've done it with your skeleton warrior.
			///==============================================
			///Create a method that takes an argument
			public void methodArgument1(int x, int y)
			{
				//Nice work, this is how you set arguments, he'll ask you to do something with the method too.
			}
			/// in this case the argument is (int x, int y)

			///=======================================
			///• Create a method that takes an argument* and* at least one optional argument
			public void methodArgument2(int x, int y = 15)
			{
				//Good job, same feedback as above.
			}

			/// in this exsample the optinal argument is the int y = 15 were =15 is the optional argument, this can be overwriten if needed.

			//=============================================================================
			///• Create, subscribe and react to an event

			/// this has been cometed out due to build errors that only apply because of the way i have listed the ansers to the question, 
			///all code has been run and tested in an diffrent aplication!!!!!!!!!!!!!!!!!!!!!!!!!!!!

			//This is spot on!!!! He will probably ask you to put the event behind an if statement such as if you can set it off when an int value hits a certain amount
			//Think a timer on a bomb

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

			//This is spot on, he will probably ask you to different things with the button(call different methods)

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
			/// This is correct, its what i did with him when he showed me, giving a custom criteria to add to a new list.
			/// He will probably get you to do the criteria with a custom class instead of an int.
			/// So for example if(Flower.Rot == true)
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
			///Spot on, he will ask you to run it. And your right about looking at timers
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


			////==================== score is 19/21


		}

	}
}
