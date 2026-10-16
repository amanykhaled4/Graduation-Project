# بيانات تجريبية للفرونت إند

استخدم الملف ده علشان تبني صفحات الويب **من غير ما تستنى الباك إند**. البيانات بنفس الشكل اللي السيرفر هيرجّعه، فلما الباك إند يجهز هنغيّر عنوان واحد بس.

## فيه إيه

| الجزء | بيستخدم في صفحة |
|---|---|
| `doctor` | الهيدر (اسم الدكتور) |
| `stats` | Overview: الأرقام والرسم البياني |
| `gradeNames` | أسماء الـ 5 درجات (الرقم 0 = No DR ... 4 = Proliferative DR) |
| `patients` | صفحة المرضى (الجدول) |
| `scans` | صفحة نتيجة الفحص |
| `images/` | صور الشبكية والـ Heatmap |

## إزاي تقرأه بـ JavaScript

```js
async function loadData() {
    const response = await fetch("data/mock-data.json");
    const data = await response.json();

    console.log(data.patients);  // كل المرضى
    console.log(data.stats.totalPatients);  // 8
}

loadData();
```

⚠️ لازم تفتح الصفحة بـ **Live Server** (كليك يمين على الملف ← Open with Live Server). لو فتحتها دبل كليك من الفولدر، الـ `fetch` مش هيشتغل.

## مثال: جدول المرضى

```js
const data = await (await fetch("data/mock-data.json")).json();

document.getElementById("patientsBody").innerHTML = data.patients.map(p => `
    <tr>
        <td>${p.code}</td>
        <td>${p.fullName}</td>
        <td>${p.age}</td>
        <td>${data.gradeNames[p.latestGrade]}</td>
    </tr>
`).join("");
```

## الشكل اللي المفروض توصله
افتح النموذج الأولي: https://claude.ai/artifact/1FFBfC7rc7vtefnbRJ6tDY
