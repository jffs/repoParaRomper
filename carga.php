  move_uploaded_file($_FILES['foto']['tmp_name'],$target_path);
  echo "La foto fue subida con exito!<br>";

  echo "Podés encontrarla <a href=$target_path >aqui</a>";
}
