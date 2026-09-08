const button = document.getElementById("factButton");
const status = document.getElementById("status");
const factContainer = document.getElementById("factContainer");
const fact = document.getElementById("fact");
const length = document.getElementById("length");

button.addEventListener("click", async () => {
    status.textContent = "IN PROGRESS...";
    button.disabled = true;

    try {
        const response = await fetch("/api/CatFact");

        if (!response.ok) {
            throw new Error("Cant download cat fact :(");
        }

        const data = await response.json();

        fact.textContent = data.fact;
        length.textContent = `LENGTH: ${data.length}`;

        factContainer.classList.remove("hidden");
        status.textContent = "DONE!";
    } catch (error) {
        status.textContent = "SOMETHING WENT WRONG";
        console.error(error);
    } finally {
        button.disabled = false;
    }
});