<?php
 date_default_timezone_set('America/New_York');
    $uploaded_type = $_FILES[ 'foto' ][ 'type' ]; 
    $uploaded_name = $_FILES[ 'foto' ][ 'name' ]; 
	$uploaded_ext  = substr( $uploaded_name, strrpos( $uploaded_name, '.' ) + 1); 

   // if( ( $uploaded_type == "image/jpeg" || $uploaded_type == "image/png" )) { 
if ( strtolower( $uploaded_ext ) == "jpg" || strtolower( $uploaded_ext ) == "jpeg" || strtolower( $uploaded_ext ) == "png" ){
       
 $target_path  = "./imagenes/"; //Directorio donde se almacenarán las imagenes
  $target_path .= basename( $_FILES[ 'foto' ][ 'name' ] ); 
  move_uploaded_file($_FILES['foto']['tmp_name'],$target_path);
  echo "La foto fue subida con exito!<br>";
  echo "Podés encontrarla <a href=$target_path >aqui</a>";
}
  else echo "El archivo debe ser JPEG o PNG";

 ?>