// عنوان الـ Backend — لو اتغير، نغيره هنا بس
const API_BASE = "http://localhost:5210/api";

// function عامة لأي طلب GET للـ API
async function apiGet(path) {
    const response = await fetch(API_BASE + path);
    if (!response.ok) {
        throw new Error("Request failed: " + response.status);
    }
    return response.json();
}
