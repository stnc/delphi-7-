<?php



///
 class AnaSf {
	public function deneme() {
		echo "AnaSınıf::deneme() çağrıldı\n";
	}

	// Burada işlevi final olarak belirtmenin bir önemi yoktur
	final public function bakaDeneme() {
		echo "başka deneme olayı geldi \n";
	}
}

class child_class extends AnaSf {
 function denemes(){
 	echo 'dsds';
 	
 }
}
$a= new child_class();
$a->denemes();
$a->bakaDeneme();

// Ölümcül hata ile sonuçlanır: ÇocukSınıf final bir sınıf
// olan AnaSınıf'ın çocuğu olarak oluşturulamaz
//son



class AnaSf {
	public function deneme() {
		echo "AnaSınıf::deneme() çağrıldı\n";
	}

	final public function backaDeneme() {
		echo "AnaSınıf::başkaDeneme() çağrıldı\n";
	}
}

class ccukSf extends AnaSf {
	public function backaDeneme() {
		echo "ÇocukSınıf::başkaDeneme() çağrıldı\n";
	}
}






?>