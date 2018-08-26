<?php
//http://www.hiteshagrawal.com/php/oops-in-php5-tutorial-function-overriding
class Person
{
	function calculateAge($dob)
	{
		echo "calculateAge called of Person Classn";
	}
}

class Customer extends Person
{
	function calculateAge($dob)
	{
		echo "calculateAge called of Customer Classn";
	}
}

$c1 = new Customer();
$p1 = new Person();

//$c1->calculateAge("something");
//$p1->calculateAge("something More");

class A {

	public function test($param) {
		echo "<br> Parent - the parameter value is $param";
	}
	}

	class B extends A {

	public function test($param) {
	echo "<br> Child - the parameter value is $param";
	}
	}

	$objA = new A;
	$objB = new B;

	$objA->test('class A');
	$objB->test('class B');
	
	
	

class eclipse {
	function  deneme_turs($mic)
	{
		echo 'merhaba eclipse<br/>';
	}
	
}

 class  deneme_tur extends  eclipse{
 	
 	function deneme_turs($mic){
 		
 		echo 'mnci mici<br/>';
 		
 	}
 	
 	
 }
 
 $a1= new eclipse();
$a2=new  deneme_tur();
$a1->deneme_turs('dememe');
$a2->deneme_turs('sss');


?>