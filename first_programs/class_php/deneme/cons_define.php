<?php
define ("selman","deneme");
echo selman;

	echo "<br>";
class MyClass
{
    const constant = 'sabit değer';
    static $uye="selman";
    function showConstant() {
        echo  self::constant . "\<br>";
		echo  self::$uye . "<br>";
    }
}

echo MyClass::constant . "\<br/>";

$classname1 = "MyClass";
echo $classname1::constant . "\<br>"; // PHP 5.3.0'dan itibaren

$class = new MyClass();
$class->showConstant();

//echo $class::constant."\<br>"; // PHP 5.3.0'dan itibaren


class oda {
 
const selam = "selamlar";
public function add() {
 
echo constant('oda::selam');


 //static ullanımı 
 
 class siteayarlari
{
    private static $ismi = 'Tasarim rehberi';
 
    public static function ismigoster()
    {
        echo self::$ismi;
    }
}
 
siteayarlari::ismigoster();


?>