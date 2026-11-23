<!DOCTYPE html>
<html lang="pl">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Dane użytkownika</title>
</head>
<body>
    <h1>Dane użytkownika</h1>
    <form method="get">
        <input type="text" name="firstName"><br><br>
        <input type="text" name="lastName"><br><br>
        <select name="city">
            <option value="Poznań">Poznań</option>
            <option value="Gniezno">Gniezno</option>
        </select>
        <input type="submit" value="Zatwierdź">
    </form>
    <?php
        print_r($_GET);
        // if (isset($_GET["firstName"])) {
        //     $firstName = $_GET["firstName"];
        //     $lastName = $_GET["lastName"];
        //     echo "Imię i nazwisko: $firstName $lastName<hr>";

        // }
    ?>
</body>
</html>