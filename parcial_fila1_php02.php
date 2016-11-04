<?php

//interface de conexion
interface DB{	
  	//metodo para implementacion en  diferentes motores de bd
	private function conectar();
}

//clase para el motor oracle
class Oracle implements DB{
  	//constantes 
  	const DB_USERNAME_ORACLE = 'username';
 	const DB_PASSWORD_ORACLE = 'pass';
	const DB_DATABASE_ORACLE = 'database';
	//atributos privados
	private $conexion;
	private $consulta_sql;	
 	//metodo para conexion a oracle  
 	private function conectar(){
	  	$this->conexion = oci_connect(self::DB_USERNAME_ORACLE,self::DB_PASSWORD_ORACLE,self::DB_DATABASE_ORACLE);
		//validadr si la conexion fue correcta
	}

	//metodo obtener datos sql
	public  function ObtenerDatosDesdeSQL($sql){
	    //conexion
	  	$this->conectar();
	  	$this->consulta_sql = oci_parse($this->conexion,$sql);
		//ejecutamos la consulta
		oci_execute($this->consulta_sql);
		//imprimir los datos
		print_r($this->consulta_sql);
	}

	private function Desconectar(){
	  	//metodo de conexion
		$this->conectar();
	 	oci_close($this->conexion);
	}

	public function cerrarConexion(){
		$this->Desconectar();
	}

}
//CONECCTAR CON MYSQL
/*class mysql implements BD{
	//
}*/


//instancia oracle
$instancia_oracle = new Oracle();
$instancia_oracle->conectar();
//ingresar consulta sql
$instancia_oracle->ObtenerDatosDesdeSQL("SELECT * from INMUEBLE WHERE SUPERFICIE > 1500");
$instancia_oracle->cerrarConexion();
