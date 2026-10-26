<?php
    session_start();

    if (!isset($_SESSION["loggedIn"]) || $_SESSION["loggedIn"] !== true) {
        header("Location: index.php");
        exit();
    }

    $user = $_SESSION["user"];
    
    $safeUser = htmlspecialchars($user, ENT_QUOTES, "UTF-8");

    $sessionId = session_id();
    // echo $sessionId;
?>
<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Panel użytkownika</title>
</head>
<body>
    <h1>Panel użytkownika</h1>

    <h2>Witaj, <?= $safeUser ?>!</h2>

    <p>Logowanie zakończone powodzeniem</p>

    <h3>Informacje o sesji</h3>

    <p>
        Login użytkownika:
        <?= $safeUser ?>
    </p>

    <p>
        Status:
        <?= $_SESSION["loggedIn"] ? "Zalogowany" : "Niezalogowany" ?>
    </p>

    <p>
        Identyfikator sesji:
        <?= htmlspecialchars($sessionId, ENT_QUOTES, "UTF-8") ?>
    </p>

    <a href="logout.php">Wyloguj się</a>
</body>
</html>