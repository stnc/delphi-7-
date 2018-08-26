<?php
interface Personel {
	public function tabiOlduguYasa();
}

class Memur implements Personel {
	public function tabiOlduguYasa(){
		echo "657 sayılı Devlet Memurları Kanunu...";
	}
}

class Isci implements Personel {
	public function tabiOlduguYasa(){
		echo "1475 sayılı İş Kanunu...";
	}
}

$re = new personel();


$d=new Memur();
echo $d->tabiOlduguYasa();

$ds= new Isci();
$ds->tabiOlduguYasa();
/*
 * 
 * Kodumuzda görüldüğü üzere, Personel isminde, “interface” anahtarı ile deklare edilmiş ve tabiOlduğuYasa 
 * isminde gövdesiz bir metoda sahip bir arayüzümüz var. 
 * Personel arayüzünü iki sınıf/nesnenin, “impelements” anahtarı ile implement ettiğine yani uyguladığına 
 * ve arayüzün sahip olduğu metodu iptal/override ettiğine dikkat edin. Bu iptal/override işlemi, Personel
 *  arayüzünü uygulayan her sınıf/nesne için bir zorunluluktur.

Basit bir arayüz deklerasyon ve implementasyonunu gördüğümüze göre, tıpkı soyut 
sınıf/nesnelerde olduğu gibi ilk başta aklınıza gelebilecek muhtemel “peki ama neden/nerede, nesne
 arayüzlerini kullanayım/kullanmalıyım?” sorusunun cevabına gelelim.

Bu sorunun cevabı, soyut sınıf/nesneler için verilen cevapta olduğu gibi “birleştirici rol”ün anlam
 ve mahiyetinde gizlidir.
 
 Nesne arayüzleri soyut sınıf/nesnelere çok benzerler, nesne arayüzlerinin soyut sınıf/nesnelerden ayrıldıkları 
 temel nokta, gövdeli yordamlar
  barındırmamaları ve içerdikleri metod ve özelliklerin public erişim belirteçine sahip olma zorunluluğudur.
 
 Temelde soyut sınıf/nesneler ile nesne arayüzlerinin amacı, gövdesiz metodlarını kendilerini 
 genişleten/uygulayan sınıflara iptal/override ettirmektir. Dolayısıyla, sınıf/nesnelerimizin mutlaka
  ihtiva etmeleri gerektiğini düşündüğümüz metodlarımız varsa, 
 soyut  sınıf/nesneler ile nesne arayüzlerine başvurarak, sınıf/nesnelerimizi buna zorlarız
 
  nesne arayüzleri diğer nesne arayüzlerince genişletilebilir. 
  nese arayüzlerini uygulayan soyut/abstract sınıf/nesnelerin böyle bir zorunluluğu yoktur
  
  
  
 * */
