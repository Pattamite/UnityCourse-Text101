using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TextController : MonoBehaviour {

	public Text text;
	private enum States {table_1, problem, f1_algo, f1_code, table_2, f2_code, table_3, table_4, bug, bug_2, bug_3, end};
	private States current;

	// Use this for initialization
	void Start () {
		current=States.table_1;
	}
	
	// Update is called once per frame
	void Update () {
		print(current);
		if     (current==States.table_1) 	table_1();
		else if(current==States.problem) 	problem();
		else if(current==States.f1_algo) 	f1_algo();
		else if(current==States.f1_code) 	f1_code();
		else if(current==States.table_2) 	table_2();
		else if(current==States.table_3) 	table_3();
		else if(current==States.table_4) 	table_4();
		else if(current==States.bug) 		bug();
		else if(current==States.bug_2) 		bug_2();
		else if(current==States.bug_3) 		bug_3();
		else if(current==States.end) 		end();
		else if(current==States.f2_code) 	f2_code();
		
	}
	#region States method
	void table_1()
	{
		text.text="ตอนนี้คุณกำลังนั่งสอบแลปวิชาคอมโปรอยู่\n"
			+" บนโต๊ะสอบของคุณมีกระดาษคำถาม กระดาษทด และคอมพิวเตอร์สำหรับเขียนโค๊ด\n\n"
			+"1 > อ่านกระดาษคำถาม\n"
			+"2 > เขียนอัลกอริทึมบนกระดาษทด\n"
			+"3 > เขียนโค๊ดบนคอมพิวเตอร์";
			
		if(Input.GetKeyDown(KeyCode.Keypad1)) current=States.problem;
		else if(Input.GetKeyDown(KeyCode.Keypad2)) current=States.f1_algo;
		else if(Input.GetKeyDown(KeyCode.Keypad3)) current=States.f1_code;
	}
	
	void problem()
	{
		text.text="บนกระดาษคำถามมีโจทย์อยู่หนึ่งข้อ\n"
			+"\"จงเขียนโปรแกรมรับเลขจำนวนเต็ม a และ b แล้วแสดงเลขที่ค่าเท่ากับผลคูณของ a และ b\"\n\n"
			+"1 > ย้อนกลับไปที่โต๊ะ";
			
		if(Input.GetKeyDown(KeyCode.Keypad1)) current=States.table_2;
	}
	
	void f1_algo()
	{
		text.text="คุณกำลังคิดอัลกอริทึมอย่างหนัก\n"
			+"แต่พึ่งนึกได้ว่าจะคิดอัลกอริทึมออกได้อย่างไรถ้ายังไม่รู้เลยว่าโจทย์เขียนว่าอะไร\n\n"
			+"1 > ย้อนกลับไปที่โต๊ะ";
			
		if(Input.GetKeyDown(KeyCode.Keypad1)) current=States.table_1;
	}
	
	void f1_code()
	{
		text.text="คุณกำลังเริ่มเขียนเมทธอด Main แต่พึ่งนึกได้ว่าตัวเองยังไม่รู้เลยด้วยซ้ำว่าจะเขียนอะไร\n\n"
			+"1 > ย้อนกลับไปที่โต๊ะ";
			
		if(Input.GetKeyDown(KeyCode.Keypad1)) current=States.table_1;
	}
	
	void table_2()
	{
		text.text="คุณอ่านกระดาษคำถามเสร็จแล้ว\n"
			+"บนโต๊ะสอบของคุณมีกระดาษคำถาม กระดาษทด และคอมพิวเตอร์สำหรับเขียนโค๊ด\n\n"
			+"1 > อ่านกระดาษคำถาม\n"
			+"2 > เขียนอัลกอริทึมบนกระดาษทด\n"
			+"3 > เขียนโค๊ดบนคอมพิวเตอร์";
			
		if(Input.GetKeyDown(KeyCode.Keypad1)) current=States.problem;
		else if(Input.GetKeyDown(KeyCode.Keypad2)) current=States.table_3;
		else if(Input.GetKeyDown(KeyCode.Keypad3)) current=States.f2_code;
	}
	
	void f2_code()
	{
		text.text="คุณกำลังเริ่มเขียนเมทธอด Main แต่พึ่งนึกได้ว่าตัวเองยังไม่รู้เลยด้วยซ้ำว่าจะเขียนอะไร\n\n"
			+"1 > ย้อนกลับไปที่โต๊ะ";
			
		if(Input.GetKeyDown(KeyCode.Keypad1)) current=States.table_2;
	}
	
	void table_3()
	{
		text.text="คุณคิดและเขียนอัลกอรึทึมเรียบร้อยแล้ว ตอนนี้เหลือเพียงแค่เขียนโค๊ดเท่านั้น\n\n"
			+"1 > เขียนโค๊ดบนคอมพิวเตอร์\n"
			+"2 > กินขนมที่เขาแจกให้บนโต๊ะก่อนสอบ (ノ*゜▽゜*)";
		if(Input.GetKeyDown(KeyCode.Keypad1)) current=States.bug;
		else if(Input.GetKeyDown(KeyCode.Keypad2)) current=States.table_4;
	}
	
	void table_4()
	{
		text.text="ok . . . จะกินก่อนก็ได้ พร้อมที่จะเขียนโค๊ดหรือยัง\n\n"
			+"1 > เขียนโค๊ดบนคอมพิวเตอร์";
			
		if(Input.GetKeyDown(KeyCode.Keypad1)) current=States.bug;
	}
	
	void bug()
	{
		text.text="คุณเขียนโค๊ดเสร็จแล้ว หลังจากนั้นคุณกดปุ่ม compile เพื่อดูว่าโค๊ดนั้นมีปัญหาหรือไม่\n"
			+"โปรแกรม editor บอกว่าโค๊ดบรรทัดนี้มีปัญหา\n"
			+"Console.WriteLine(a*b + \"\\n\")\n\n"
			+"1 > เติม ; ไว้หลังสุดของบรรทัดนี้\n"
			+"2 > เติม : ไว้หลังสุดของบรรทัดนี้\n"
			+"3 > เติม . ไว้หลังสุดของบรรทัดนี้\n";
			
		if(Input.GetKeyDown(KeyCode.Keypad1)) current=States.end;
		else if(Input.GetKeyDown(KeyCode.Keypad2)) current=States.bug_2;
		else if(Input.GetKeyDown(KeyCode.Keypad3)) current=States.bug_3;
	}
	
	void bug_2()
	{
		text.text="คุณพยายามแก้โดยการเติม : ไว้หลังสุดของบรรทัดนี้\n"
			+"แต่โปรแกรม editor บอกว่าโค๊ดบรรทัดนั้นมีปัญหาอยู่ดี"
			+"Console.WriteLine(a*b + \"\\n\")\n\n"
			+"1 > เติม ; ไว้หลังสุดของบรรทัดนี้\n"
			+"2 > เติม : ไว้หลังสุดของบรรทัดนี้\n"
			+"3 > เติม . ไว้หลังสุดของบรรทัดนี้\n";
			
		if(Input.GetKeyDown(KeyCode.Keypad1)) current=States.end;
		else if(Input.GetKeyDown(KeyCode.Keypad2)) current=States.bug_2;
		else if(Input.GetKeyDown(KeyCode.Keypad3)) current=States.bug_3;
	}
	
	void bug_3()
	{
		text.text="คุณพยายามแก้โดยการเติม . ไว้หลังสุดของบรรทัดนี้\n"
			+"แต่โปรแกรม editor บอกว่าโค๊ดบรรทัดนั้นมีปัญหาอยู่ดี"
				+"Console.WriteLine(a*b + \"\\n\")\n\n"
				+"1 > เติม ; ไว้หลังสุดของบรรทัดนี้\n"
				+"2 > เติม : ไว้หลังสุดของบรรทัดนี้\n"
				+"3 > เติม . ไว้หลังสุดของบรรทัดนี้\n";
		
		if(Input.GetKeyDown(KeyCode.Keypad1)) current=States.end;
		else if(Input.GetKeyDown(KeyCode.Keypad2)) current=States.bug_2;
		else if(Input.GetKeyDown(KeyCode.Keypad3)) current=States.bug_3;
	}
	
	void end()
	{
		text.text="คุณพยายามแก้โดยการเติม ; ไว้หลังสุดของบรรทัดนี้  หลังจากนั้นคุณกดปุ่ม compile\n"
			+"โปรแกรม editor ไม่ฟ้องว่าบรรทัดไหนมีปัญหา หน้าต่างโปรแกรมใหม่โผล่ขึ้นมา\n"
		    +"คุณทดสอบโปรแกรมที่เขียนขึ้นมาจนแน่ใจว่าไม่มีปัญหา  แล้วส่งโปรแกรมนั้นผ่านโปรแกรม putty\n";
	}
	#endregion
}

