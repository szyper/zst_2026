<?php
    session_start();

    $_SESSION = [];

    if (ini_get("session.use_cookies")) {
        $params = session_get_cookie_params();

        $options = [
            "expires" => time() - 3600,
            "path" => $params["path"],
            "domain" => $params["domain"],
            "secure" => $params["secure"],
            "httponly" => $params["httponly"]
        ];

        if (!empty($params["samesite"])) {
            $options["samesite"] = $params["samesite"];
        }

        setcookie(session_name(), "", $options);
    }

    session_destroy();

    header("Location: index.php");

    exit();
?>