<?php
interface Bitki {
	public function familya();
	public function govde();
}

interface Agac extends Bitki{
	public function yaprak();
}

interface Patates extends Bitki{
	public function renk();
}

class Kavak implements Agac{

	public function familya(){
		return "SALİCACEAE";
	}
	public function govde(){
		return "ODUNSU";
	}

	public function yaprak(){
		return "YAPRAKLI";
	}

	public function getAdi(){
		return "Kavak Ağacı";
	}
}

class Granula implements Patates {

	public function familya(){
		return "SOLANACEAE";
	}

	public function govde(){
		return "YUMRU";
	}

	public function renk(){
		return "SARI";
	}

	public function getAdi(){
		return "Granula Patates";
	}
}


class Goster {

	public function Info(Bitki $bitki){
		echo $bitki->getAdi().", Familyası: ".$bitki->familya()." Gövdesi: ".$bitki->govde()."<br>";
	}

}

$goster  = new Goster;
$kavak   = new Kavak;
$granula = new Granula;

$goster->Info($kavak);
$goster->Info($granula);

/**
 *
 Kavak isimli sınıf/nesne Agac arayüzünü implement ederken, Granula sınıf/nesnesi ise Patates arayüzünü implement ediyor.
 Her iki sınıf, uyguladıkları arayüzlerin gövdesiz metodlarını iptal/override ediyor. Burada dikkat edilmesi gereken,
 iptal/override edilen metodlar arasında Bitki arayüzünde deklare edilen familya ve govde metodlarının da olmasıdır.
 Bunun sebebi, Agac ve Patates arayüzlerinin kalıtım yolu ile Bitki arayüzünden bu metodları miras almış olmalarıdır.
 */