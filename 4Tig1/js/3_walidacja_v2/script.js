// =================================
// WALIDACJA IMIENIA
// =================================
 
function validateName() {
    // pobieramy pole imienia
    const field = document.getElementById("name");

    // pobieramy miejsce na komunikat
    const message = document.getElementById("nameError");

    // pobieramy wpisane imię
    const name = field.value.trim();

    // sprawdzamy czy pole jest puste
    if (name === "") {
        message.textContent = "Podaj imię.";
        message.className = "error";
        field.classList.add("input-error");
        field.classList.remove("input-success");
        return false;
    }

    const namePattern = /^[a-zA-ZąęćżźńłóĄĘĆŻŹŃŁÓ]{2,}$/;

    if (!namePattern.test(name)) {
        message.textContent = "❌ Imię musi zawierać minimum 2 litery, bez cyfr i znaków specjalnych";
        message.className = "error";
        field.classList.add("input-error");
        field.classList.remove("input-success");
        return false;
    }

    // imię jest poprawne
    message.textContent = "✅ Imię jest poprawne.";
    message.className = "success";
    field.classList.add("input-success");
    field.classList.remove("input-error");
    return true;
}


// =================================
// WALIDACJA nazwiska
// =================================
 
function validateSurname() {
    const field = document.getElementById("surname");
    const message = document.getElementById("surnameError");

    const surname = field.value.trim();

    if (surname === "") {
        message.textContent = "Podaj nazwisko.";
        message.className = "error";
        field.classList.add("input-error");
        field.classList.remove("input-success");
        return false;
    }

    const surnamePattern = /^[a-zA-ZąęćżźńłóĄĘĆŻŹŃŁÓ]{2,}(-[a-zA-ZąęćżźńłóĄĘĆŻŹŃŁÓ]+)*$/;

// * — zero lub więcej powtórzeń
// ? — zero lub jedno powtórzenie
// + — jedno lub więcej powtórzeń

    if (!surnamePattern.test(surname)) {
        message.textContent = "❌ Nazwisko musi zawierać minimum 2 litery, bez cyfr, może zawierać myślnik";
        message.className = "error";
        field.classList.add("input-error");
        field.classList.remove("input-success");
        return false;
    }

    message.textContent = "✅ Nazwisko jest poprawne.";
    message.className = "success";
    field.classList.add("input-success");
    field.classList.remove("input-error");
    return true;
}


// =================================
// WALIDACJA e-mail
// =================================
 
function validateEmail() {
    const field = document.getElementById("email");
    const message = document.getElementById("emailError");

    const email = field.value.trim();

    if (email === "") {
        message.textContent = "Podaj adres email.";
        message.className = "error";
        field.classList.add("input-error");
        field.classList.remove("input-success");
        return false;
    }

    const emailPattern = /^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$/;

    if (!emailPattern.test(email)) {
        message.textContent = "❌ Email musi być adresem poczty elektronicznej";
        message.className = "error";
        field.classList.add("input-error");
        field.classList.remove("input-success");
        return false;
    }

    message.textContent = "✅ Nazwisko jest poprawne.";
    message.className = "success";
    field.classList.add("input-success");
    field.classList.remove("input-error");
    return true;
}


// =================================
// WALIDACJA WIEKU
// =================================
 
function validateAge() {
    const field = document.getElementById("age");
    const message = document.getElementById("ageError");

    const ageText = field.value.trim();
    const age = Number(ageText);

    if (age === "") {
        message.textContent = "Podaj wiek.";
        message.className = "error";
        field.classList.add("input-error");
        field.classList.remove("input-success");
        return false;
    }

    if (!Number.isInteger(age) || age < 1 || age > 150) {
        message.textContent = "❌ Email musi być adresem poczty elektronicznej";
        message.className = "error";
        field.classList.add("input-error");
        field.classList.remove("input-success");
        return false;
    }

    message.textContent = "✅ Wiek jest poprawny.";
    message.className = "success";
    field.classList.add("input-success");
    field.classList.remove("input-error");
    return true;
}



// =================================
// WALIDACJA CAŁEGO FORMULARZA
// =================================

function validateForm() {
    // na początku zakładamy, że formularz jest poprawnie wypełniony
    let valid = true;

    // sprawdzamy imię
    if (!validateName()) {
        valid = false;
    }

    return valid;
}


// ===================================
// SPRAWDZENIE PÓL PO ICH OPUSZCZENIU
// ===================================

// Imię
document.getElementById("name").addEventListener("blur", validateName);



// ===================================
// WYSŁANIE FORMULARZA
// ===================================

const form = document.getElementById("registrationForm");

form.addEventListener("submit", function(event){
    // zatrzymuję standardowe wysyłanie formularza
    event.preventDefault();

    // sprawdzamy wszystkie pola
    const valid = validateForm();

    // ====================
    // JEŻELI SĄ BŁĘDY
    // ====================

    if (!valid) {
        // nie kasujemy danych z formularza
        return;
    }

    // ==============================================
    // JEŻELI WSZYSTKIE WPROWADZONE DANE SĄ POPRAWNE
    // ==============================================

    const name = document.getElementById("name").value.trim();

    // wyświetlamy podsumowanie
    showResult(name);
});


// ==============================================
// WYŚWIETLAMY PODSUMOWANIE
// ==============================================

function showResult(name) {
    // ukrywamy formularz
    document.getElementById("formCard").classList.add("hidden");

    // pokazujemy podsumowanie
    document.getElementById("resultCard").classList.remove("hidden");

    // wyświetlamy dane
    document.getElementById("result").innerHTML = `
        <strong>Dane uczestnika:</strong><br><br>
        
        Imię i nazwisko: 
        <b>${name}</b><br>
    `;
}


// ==============================================
// POPRAWIANIE DANYCH
// ==============================================

function editData() {
    // ukrywamy podsumowanie
    document.getElementById("resultCard").classList.add("hidden");

    // pokazujemy formularz
    document.getElementById("formCard").classList.remove("hidden");
}