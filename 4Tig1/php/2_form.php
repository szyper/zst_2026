<!DOCTYPE html>
<html lang="pl">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link rel="stylesheet" href="./styles/2_style.css"></link>
    <title>Dane użytkownika</title>
</head>
<body>
    <div class="container">
        <h1>Dane użytkownika</h1>
        <form method="post">
            <input type="text" name="firstName" placeholder="Wpisz imię"><br><br>
            
            <input type="text" name="lastName" placeholder="Wpisz nazwisko"><br><br>

            <label for="email">Adres e-mail:</label>
            <input type="email" name="email" id="email" placeholder="example@o2.pl" required><br><br>

            <label for="birthDate">Data urodzenia:</label>
            <input type="date" name="birthDate" id="birthDate"><br><br>

            <select name="city"><br><br>
                <option value="Poznań">Poznań</option>
                <option value="Gniezno">Gniezno</option>
            </select><br><br>

            <p>Płeć</p>
            <input type="radio" name="gender" id="woman" value="kobieta" checked>
            <label for="woman">Kobieta</label>

            <input type="radio" name="gender" id="man" value="mężczyzna">
            <label for="man">Mężczyzna</label><br><br>

            <label for="message">Dodatkowa wiadomość:</label><br>
            <textarea name="message" id="message" rows="5" cols="30"></textarea><br><br>

            <div class="agreement">
                <input type="checkbox" name="agreement" id="agreement" required>
                <label for="agreement">
                    Zgadzam się na przetwarzanie danych
                </label>
            </div>

            <button type="submit">Zatwierdź</button>
        </form>
    </div>
    
    <?php
    $data  = [];

        if ($_SERVER["REQUEST_METHOD"] === "POST" && !empty($_POST["firstName"])) {
            $firstName = htmlspecialchars($_POST["firstName"] ?? "");
            $lastName = htmlspecialchars($_POST["lastName"] ?? "");
            $city = htmlspecialchars($_POST["city"] ?? "");
            $email = htmlspecialchars($_POST["email"] ?? "");
            $birthDate = htmlspecialchars($_POST["birthDate"] ?? "");
            $gender = htmlspecialchars($_POST["gender"] ?? "");
            $message = htmlspecialchars($_POST["message"] ?? "");
            
            echo "<hr>";
            echo "<h2>Wprowadzone dane:</h2>";
            echo "<p>Imię: <strong>$firstName</strong></p>";
            echo "<p>Nazwisko: <strong>$lastName</strong></p>";
            echo "<p>Miasto: <strong>$city</strong></p>";
            echo "<p>Email: <strong>$email</strong></p>";
            echo "<p>Data urodzenia: <strong>$birthDate</strong></p>";
            echo "<p>Płeć: <strong>$gender</strong></p>";
            echo "<p>Wiadomość: <strong>$message</strong></p>";

            // echo "<hr><a href=\"tabela.php\">Zobacz wszystkie dane w tabeli</a>";

            $data = $_POST;
            // print_r($data);

            if (!empty($data)) {
                ?>
                <hr>
                <table>
                    <tr>
                        <th>Imię</th>
                        <th>Nazwisko</th>
                        <th>Miasto</th>
                        <th>Email</th>
                        <th>Data urodzenia</th>
                        <th>Płeć</th>
                        <th>Wiadomość</th>
                    </tr>
                <?php
                    echo "<tr>";
                        foreach ($data as  $key => $value) {
                            if ($key === "agreement") {
                                continue;
                            }
                            echo "<td>$value</td>";
                        }
                    echo "</tr></table>";
                
            } else {
                echo "Brak danych do wyświetlenia";
            }
        }
        
        //print_r($_SERVER);
        //print_r($_POST);
        // print_r($data);

        // if (isset($_GET["firstName"])) {
        //     $firstName = $_GET["firstName"];
        //     $lastName = $_GET["lastName"];
        //     echo "Imię i nazwisko: $firstName $lastName<hr>";

        // }
    ?>
</body>
</html>