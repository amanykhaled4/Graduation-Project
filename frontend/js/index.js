const checkBtn = document.getElementById("checkBtn");
const result = document.getElementById("result");

checkBtn.addEventListener("click", async () => {
    result.textContent = "Checking...";
    result.className = "result";

    try {
        const data = await apiGet("/health");
        result.textContent = "✔ " + data.message;
        result.classList.add("ok");
    } catch (error) {
        result.textContent = "✖ API is not running. Start the backend first.";
        result.classList.add("error");
    }
});
