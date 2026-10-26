<?php
    session_start();
    if (isset($_SESSION["loggedIn"]) && $_SESSION["loggedIn"] == true) {
        header("Location: panel.php");
        exit();
    }
?>
<!DOCTYPE html>
<html lang="pl">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Logowanie użytkownika</title>
</head>
<body>
    <h1>Logowanie użytkownika</h1>
    <form action="login.php" method="post">
        <label for="login">Login:</label>
        <input type="text" name="login" id="login" autofocus required><br><br>

        <label for="password">Hasło:</label>
        <input type="password" name="password" id="password" required><br><br>

        <button type="submit">Zaloguj</button>
    </form>
</body>
</html>