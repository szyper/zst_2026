<?php
    $serwer = 'localhost';
    $uzytkownikBazy = 'root';
    $hasloBazy = '';
    $nazwaBazy = '5_ti_login';

    $komunikat = '';
    $loginWartosc = '';
    $emailWartosc = '';

    if (isset($_POST['add'])) {
        $login = $_POST['login'];
        $haslo = $_POST['pass'];
        $email = $_POST['email'];

        $loginWartosc = trim($login);
        $emailWartosc = trim($email);

        if ($loginWartosc === '' || $pass === '' || $emailWartosc === '') {
            $komunikat = 'Wypełnij wszystkie pola';
        } elseif (!filter_var()){

        }
    }
?>
<!DOCTYPE html>
<html lang="pl">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Dodaj użytkownika</title>
</head>
<body>
    <h3>Dodaj użytkownika</h3>
    <form method="post">
        <label for="login">Login:</label>
        <input type="text" name="login" id="login" maxlength="100" required><br><br>

        <label for="pass">Hasło:</label>
        <input type="password" name="pass" id="pass" required><br><br>

        <label for="email">E-mail:</label>
        <input type="email" name="email" id="email" maxlength="150" required><br><br>

        <button type="submit" name="add">Dodaj użytkownika</button>
    </form>
</body>
</html>