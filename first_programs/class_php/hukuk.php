<?php
abstract  class Hukuk {
	//abstract public  function avukat_info ($site_name,$site_owner );
	abstract public  function yapilan_islem ($islem_kodu );
	
   public function FiyatHesapla($fiyat, $islem_kodu) {
		return $fiyat + ($fiyat * $this->yapilan_islem ($islem_kodu) );
	}
}
	
	
	class Anadolu extends Hukuk {
		public $oran;
	
		public function yapilan_islem ($islem_kodu){
	
			switch($islem_kodu){
				case 1:
					$this->oran = 0.08;
					break;
				case 2:
					$this->oran = 0.18;
					break;
				default:
					$this->oran=0; 
			}
			return $this->oran;
		}
	
	}
	
	
$h1 =new Anadolu();
echo $h1->FiyatHesapla(200,1);

?>

