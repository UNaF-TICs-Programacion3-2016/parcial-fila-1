<?php

//clase abstracta figura para referencia de las clases hijas Rectangulo,Cuadrado , Triangulo
abstract class FiguraGeometrica{
	//metodos abstractos Area y Perimetros
	abstract public function Area();
	abstract public function Perimetro();
}

//Clase Cuadrado
class Cuadrado extends FiguraGeometrica{
  
  //atributos privado lado_a  
  private $lado_a = 10;
  
  //metodo calculamos el area del cuadrado
  public function Area(){
	//pow elevar numero a una potencia  pow(numero,Numero de potencia a elevar) http://php.net/manual/es/function.pow.php
  	echo pow($this->lado_a,2)."\n";
  }
  
  //metodo calculamos el Perimetro del Cuadrado
  public function Perimetro(){
  	echo "El permitro del  cuadrado es". 4 * $this->lado_a."\n";
  }

}


//clase rectangulo
class Rectangulo extends FiguraGeometrica{
  //atributos privados para rectangulo
  private $base                = 4;
  private $altura              = 2;
  private $resultado_operacion = 0;
	
  //metodo para calcular Area de un Rectangulo
  public function Area(){
	$this->resultado_operacion  = $this->base * $this->altura;
	echo "El area del Rectangulo es ".$this->resultado_operacion; 	
	echo "\n";
  }

  public function Perimetro(){
  	$this->resultado_operacion = 2*($this->base + $this->altura);
	echo "El perimetro del Rectangulo es ".$this->resultado_operacion;	
	echo "\n";
  }
}

//clase Triangulo
class Triangulo extends FiguraGeometrica{
	//atributos privados
  	private $lado_a;
	private $lado_b;
	private $lado_c;
	private $semiperiodo;
	private $resultado_area;
	private $resultado_perimetro;

	//constructor set los atributos lado_a,lado_b, lado_c
	public function __construct($lado_a,$lado_b,$lado_c){
		$this->lado_a = $lado_a;
		$this->lado_b = $lado_b;
		$this->lado_c = $lado_c;
	}

	//metodo para calcular el area del Triangulo
	public function Area(){
	    //area
	  	$this->semiperiodo    = ($this->lado_a + $this->lado_b + $this->lado_c)/2;
		//semiperiodo
		//sqrt permite calcular la raiz cuadrada de un numero http://php.net/manual/es/function.sqrt.php
		$this->resultado_area = sqrt($this->semiperiodo * ($this->semiperiodo- $this->lado_a) * ($this->semiperiodo - $this->lado_b ) * ($this->semiperiodo - $this->lado_c)  );

		//resultado
		return $this->resultado_area."\n";	
	}
	
	//metodo para calcular el perimetro del Triangulo
	public function Perimetro(){
		$this->resultado_perimetro = $this->lado_a + $this->lado_b + $this->lado_c;
		return $this->resultado_perimetro;
	}


}

//capturamos los valores ingresados por el usuario mediante POST
$lado_a =  $_POST['ladoA'];
$lado_b =  $_POST['ladoB'];
$lado_c =  $_POST['ladoC'];

//intanciamos triangulo
$instanciar_triangulo = new Triangulo($lado_a,$lado_b,$lado_c);
//Area
echo "<center></h4 id='resultado'>EL AREA DEL TRIANGULO ES ".$instanciar_triangulo->Area()."</h4></center>";
//Perimetro
echo "<center></h4 id='resultado'>EL PERIMETRO DEL TRIANGULO ES ".$instanciar_triangulo->Perimetro()."</h4></center><br><br>";


//intanciamos Rectangulo
/*$instancia_rectangulo = new Rectangulo;
$instancia_rectangulo->Area();
echo "\n";
$instancia_rectangulo->Perimetro();*/

//instanciamos Cuadrado
/*$instanciar_cuadrado = new Cuadrado;
$instanciar_cuadrado->Area();
echo "\n";
$instanciar_cuadrado->Perimetro();*/

?>
<!DOCTYPE html>
	<head>
		<title>Calculos de Figuras geometricas</title>	
	</head>
	<body>
		<center>
			<form style="border:1px solid gray;width:600px;height:300px;" method="POST" action="">
				<h3>Ingrese 3 valores de los lados</h3>
				<strong>LADO A</strong> <input type="text" value="" name="ladoA"/><br>	
				<strong>LADO B</strong> <input type="text" value="" name="ladoB"/><br>
				<strong>LADO C</strong> <input type="text" value="" name="ladoC"/><br><br>
			  <center><button type="submit" >CALCULAR </button></center>
			</form>
		</center>
	</body>
</html>  
