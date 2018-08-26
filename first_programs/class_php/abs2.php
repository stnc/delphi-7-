<?php
include 'chromephp/ChromePhp.php';

abstract class Personel {

	public $maas;
	abstract public function pozisyon();

}

class Isci extends Personel {

	function __construct($maas){
		$this -> maas = $maas;
	}

	public function pozisyon(){
		return "Pozisyon: İşçi, maaş: ".$this->maas;
	}

}

class Mudur extends Personel {

	function __construct($maas){
		$this -> maas = $maas;
	}

	public function pozisyon(){
		return "Pozisyon: Personel Müdürü, maaş: ".$this->maas;
	}

}

//$personel = new Personel; Cannot instantiate abstract class Personel
$calisan  = new Isci("750 TL");
$mudur    = new Mudur("1250 TL");

echo $calisan->pozisyon()."<br/>";
echo $mudur->pozisyon()."<br/>";


ChromePhp::log($_SERVER);

// using labels
foreach ($_SERVER as $key => $value) {
    ChromePhp::log($key,';'. $value);
}


// warnings and errors
ChromePhp::warn('this is a warning');
ChromePhp::error('this is an error');
?>