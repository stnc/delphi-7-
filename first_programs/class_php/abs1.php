<?php 
abstract class soyut_sinif {
 
    public $x = 'Selam ';
 
    public abstract function yontem1(); // Soyut yöntem; sadece tanım satırı var, gövdesi yok
 
    public function yontem2()
    {
        echo 'Merhaba ';
    }
 
}
 
class sinif extends soyut_sinif {
 
    public function yontem1() // Tanımlanmak zorunda, yoksa hata verir
    {
        echo $this->x;
        
    }
 
    public function yontem3()
    {
        echo 'Dünya';
    }
 
}
 
// $nesne = new soyut_sinif; // HATA; soyut sınıftan nesne türetilemez
 
$nesne = new sinif;
 
$nesne->yontem1();
$nesne->yontem2();
$nesne->yontem3();