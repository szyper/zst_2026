<?php
// echo "Test php"; 

   $firstName = "Janusz";
   $lastName = "Nowak";

   echo "Imię: $firstName".", nazwisko: $lastName";

   // heredoc
   echo <<< DATA
    <hr>Imię i nazwisko: $firstName $lastName
DATA;
?>