<?php


class kisiler {
static $site_adi="<h1>selmantunç<h1/>";
static $yorganci="<h2>deli haydar<h2/>";
public function __construct($gelsene)
{
echo 'site bu '.$gelsene;
}

public function _get_kim(){
echo self::$site_adi;
}
 protected function _kimsin_sen (){
echo 'şakire benden çay ';
}

protected function priva (){
echo 'en ozel yer';

}



}



class _selman extends kisiler
{

public function gelsin ()
{
 $this->priva();
 //echo parent::$yorganci;
}

 public function sakire_cay ()
{
echo parent::_kimsin_sen();
//echo self::_kimsin_sen();
}


}






/*
$d=new kisiler('selman geldi');
$d->_get_kim();

echo kisiler::$site_adi;//static cagırdım 
*/

$y=new _selman ("");
//$y->gelsin();
//$y->_kimsin_sen();//proteected denemesi
//$y->sakire_cay();//parent olayı 
$y->gelsin();//proteted olayı 

exit();
class arac
{
 static $marka = "fiat";
 public function goster()
 {
 echo self::$marka;
 }
}
class aracmodel extends arac
{
 public function modelgoster()
 {
 echo parent::$marka;
 echo "<br>model:1999";
 }
}
$arac = new arac;
$arac->goster();
echo "<hr>";
$aracmodel = new aracmodel;
$aracmodel->modelgoster();


?>