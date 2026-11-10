<?php
    session_start();

    // print_r($_POST);

        if ($_SERVER["REQUEST_METHOD"] !== "POST") {
            header("Location: index.php");
            exit();
        }

    $login = $_POST["login"] ?? "";
    $password = $_POST["password"] ?? "";

    $connect = mysqli_connect("localhost", "root", "", "5_ti_login");

    $sql = "SELECT * FROM `users` WHERE login = '$login' AND pass = '$password'";
    $result = mysqli_query($connect, $sql);

    $row = mysqli_fetch_assoc($result);

    // echo "<pre>";
    //     print_r($row);
    // echo "</pre>";

    echo mysqli_num_rows($result);

    // echo $row['login'];
    // echo $row['pass'];

    

    if ($login == $row['login'] && $password == $row['pass']) {
        session_regenerate_id(true);

        $_SESSION["user"] = $login;
        $_SESSION["loggedIn"] = true;

        header("Location: panel.php");
        exit();

    } else {
        echo "Nieprawidłowy login lub hasło";
        echo '<br><a href="index.php">Spróbuj ponownie</a>';
    }
?>
