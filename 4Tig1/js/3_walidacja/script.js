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

    // sprawdzamy długość imienia
    if (name.length < 2) {
        message.textContent = "Imię musi mieć co najmniej 2 znaki.";
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

    
});