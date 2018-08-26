<?php
interface bilgi {

	public function renkler($ilkrenk,$ortarenk,$sonrenk);

}

// bilgi arayüzünü burda bitiririz..gördüğünüz gibi methodların içerikleri boş.

// şimdi implements edip kullanalım

class renklerimiz implements bilgi {

	public function renkler($ilkrenk,$ortarenk,$sonrenk) {

		$getir="ilk rengimiz ".$ilkrenk."";
		$getir.="orta rengimiz ".$ortarenk."";
		$getir.="son rengimiz ".$sonrenk."";
		return $this->getir.=$getir;

	}

}

$renk=new renklerimiz();
echo $renk->renkler("ilk rengi yaz <br/>","orta rengi yaz <br/>","son rengi yaz <br/>");