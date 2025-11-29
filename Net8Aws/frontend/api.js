document.getElementById("callApiBtn").addEventListener("click", async () => {
    const response = await fetch("http://localhost:5200/");
    const text = await response.text();

    document.getElementById("apiResponse").innerText = text;
});
