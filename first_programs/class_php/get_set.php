<?php
//http://forum.ceviz.net/php/86615-__get-ve-__set-nedir-2.html


/*
 * bir değişkenin mesela private olduğunu düşünürseniz direk erişemezsiniz 
 * bu durumda ona değer atayan ve mevcut değerini gösteren 2 fonksiyona ihtiyaç duyarsiniz

php5 ile gelen sihirli fonksiyon olarak isimlendirilen fonksiyonlardan 
get ve set ise bu işlemi class içerisindeki tüm değişkenler için kullanilabilecek şekilde adaptif olarak yapiyor.

erişimeleyen bir değişkene erişmeye yada erişelemeyen bir değişkene değer yüklemeye
 kalktığınızda bu iki fonksiyon çağrılır. böylelikle bu fonksiyonlar üzerinden işlem yapabilirsiniz
 
 
 __get ve __set sınıf içerisindeki private olan değişken çağrılırken ya da değeri değiştirilirken php tarafından çağrılan fonsiyonlardır.


 * */

class Foo {

	private $deneme;

	public function __construct() {
		$this->deneme = "Merhaba";
	}

	public function __get($var) {
		echo 'private degisken çağrıldı. <br/>';
		return $this->$var;
	}

	public function __set($var,$value) {
		$this->$var = $value;
		echo 'private değişkene değer atandı. <br/>';
	}

}

$foo = new Foo();
echo $foo->deneme;






/*
 * __set __get aşırı yükleme denir bu sihirli yöntemlerle class içinde
 *  olmayan değişkenleri tanımlayıp set get unset isset edebilirsiniz.
var olmayan değişkenleri var mış gibi set veya get etmeye yarar.

 * */



class abc
{
	private $data = array();

	public function __set($key,$value) { $this->data[$key] = $value; }
	public function __get($key) { return $this->data[$key]; }
}

$abc = new abc;
$abc->isim = 'yusuf';
echo $abc->isim;