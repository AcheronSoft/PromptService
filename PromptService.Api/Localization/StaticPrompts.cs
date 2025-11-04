using PromptService.Api.Enums;
using PromptService.Api.Extensions;

namespace PromptService.Api.Localization;

public static class StaticPrompts
{
    private static readonly Dictionary<string, string> EnglishPrompts = new()
    {
        ["Role_Default"] = "I'm Senior Backend Developer .NET.",
        ["Context_Default"] = "Context: [briefly describe the project, situation, or goal].",
        ["Task_Default"] = "Task: [clearly formulate what exactly needs to be obtained].",
        ["Constraints_Default"] = "Constraints: [what is not allowed, requirements for technologies, style, format].",
        ["OutputFormat_Default"] = "Output Format: [in what form the result is needed - code, table, list, JSON, markdown, etc.].",
        ["QualityCriteria_Default"] = "Quality Criteria: [by what signs do you consider the result 'successful']."
    };

    private static readonly Dictionary<string, string> RussianPrompts = new()
    {
        ["Role_Default"] = "Я Senior Backend Developer .NET.",
        ["Context_Default"] = "Контекст: [опиши кратко проект, ситуацию или цель].",
        ["Task_Default"] = "Задача: [чётко сформулируй, что именно нужно получить].",
        ["Constraints_Default"] = "Ограничения: [что нельзя, требования по технологиям, стилю, формату].",
        ["OutputFormat_Default"] = "Формат ответа: [в каком виде нужен результат - код, таблица, список, JSON, markdown и т.д.].",
        ["QualityCriteria_Default"] = "Критерии качества: [по каким признакам ты считаешь, что результат 'успешный']."
    };

    private static readonly Dictionary<string, string> SpanishPrompts = new()
    {
        ["Role_Default"] = "Soy Desarrollador Backend Senior .NET.",
        ["Context_Default"] = "Contexto: [describe brevemente el proyecto, situación u objetivo].",
        ["Task_Default"] = "Tarea: [formula claramente qué se necesita obtener exactamente].",
        ["Constraints_Default"] = "Restricciones: [lo que no está permitido, requisitos de tecnologías, estilo, formato].",
        ["OutputFormat_Default"] = "Formato de Salida: [en qué forma se necesita el resultado - código, tabla, lista, JSON, markdown, etc.].",
        ["QualityCriteria_Default"] = "Criterios de Calidad: [por qué signos consideras el resultado 'exitoso']."
    };

    private static readonly Dictionary<string, string> ChineseSimplifiedPrompts = new()
    {
        ["Role_Default"] = "我是一名高级后端开发人员 .NET。",
        ["Context_Default"] = "背景: [简要描述项目、情况或目标]。",
        ["Task_Default"] = "任务: [明确说明需要获得什么]。",
        ["Constraints_Default"] = "限制: [不允许什么，技术、风格、格式要求]。",
        ["OutputFormat_Default"] = "输出格式: [结果需要以何种形式 - 代码、表格、列表、JSON、markdown 等]。",
        ["QualityCriteria_Default"] = "质量标准: [根据哪些迹象认为结果是'成功的']。"
    };

    private static readonly Dictionary<string, string> ChineseTraditionalPrompts = new()
    {
        ["Role_Default"] = "我是一名高級後端開發人員 .NET。",
        ["Context_Default"] = "背景: [簡要描述項目、情況或目標]。",
        ["Task_Default"] = "任務: [明確說明需要獲得什麼]。",
        ["Constraints_Default"] = "限制: [不允許什麼，技術、風格、格式要求]。",
        ["OutputFormat_Default"] = "輸出格式: [結果需要以何種形式 - 代碼、表格、列表、JSON、markdown 等]。",
        ["QualityCriteria_Default"] = "質量標準: [根據哪些跡象認為結果是'成功的']。"
    };

    private static readonly Dictionary<string, string> GermanPrompts = new()
    {
        ["Role_Default"] = "Ich bin Senior Backend Entwickler .NET.",
        ["Context_Default"] = "Kontext: [beschreibe kurz das Projekt, die Situation oder das Ziel].",
        ["Task_Default"] = "Aufgabe: [formuliere klar, was genau erreicht werden soll].",
        ["Constraints_Default"] = "Einschränkungen: [was nicht erlaubt ist, Anforderungen an Technologien, Stil, Format].",
        ["OutputFormat_Default"] = "Ausgabeformat: [in welcher Form das Ergebnis benötigt wird - Code, Tabelle, Liste, JSON, Markdown usw.].",
        ["QualityCriteria_Default"] = "Qualitätskriterien: [an welchen Anzeichen das Ergebnis als 'erfolgreich' gilt]."
    };

    private static readonly Dictionary<string, string> FrenchPrompts = new()
    {
        ["Role_Default"] = "Je suis Développeur Backend Senior .NET.",
        ["Context_Default"] = "Contexte: [décrivez brièvement le projet, la situation ou l'objectif].",
        ["Task_Default"] = "Tâche: [formulez clairement ce qui doit être obtenu exactement].",
        ["Constraints_Default"] = "Contraintes: [ce qui n'est pas autorisé, exigences technologiques, de style, de format].",
        ["OutputFormat_Default"] = "Format de Sortie: [sous quelle forme le résultat est nécessaire - code, tableau, liste, JSON, markdown, etc.].",
        ["QualityCriteria_Default"] = "Critères de Qualité: [par quels signes considérez-vous le résultat 'réussi']."
    };

    private static readonly Dictionary<string, string> PortuguesePrompts = new()
    {
        ["Role_Default"] = "Sou Desenvolvedor Backend Sênior .NET.",
        ["Context_Default"] = "Contexto: [descreva brevemente o projeto, situação ou objetivo].",
        ["Task_Default"] = "Tarefa: [formule claramente o que exatamente precisa ser obtido].",
        ["Constraints_Default"] = "Restrições: [o que não é permitido, requisitos de tecnologias, estilo, formato].",
        ["OutputFormat_Default"] = "Formato de Saída: [em que forma o resultado é necessário - código, tabela, lista, JSON, markdown, etc.].",
        ["QualityCriteria_Default"] = "Critérios de Qualidade: [por quais sinais você considera o resultado 'bem-sucedido']."
    };

    private static readonly Dictionary<string, string> ItalianPrompts = new()
    {
        ["Role_Default"] = "Sono uno Sviluppatore Backend Senior .NET.",
        ["Context_Default"] = "Contesto: [descrivi brevemente il progetto, la situazione o l'obiettivo].",
        ["Task_Default"] = "Compito: [formula chiaramente cosa deve essere ottenuto esattamente].",
        ["Constraints_Default"] = "Vincoli: [cosa non è consentito, requisiti per tecnologie, stile, formato].",
        ["OutputFormat_Default"] = "Formato di Output: [in quale forma è necessario il risultato - codice, tabella, elenco, JSON, markdown, ecc.].",
        ["QualityCriteria_Default"] = "Criteri di Qualità: [in base a quali segni consideri il risultato 'riuscito']."
    };

    private static readonly Dictionary<string, string> JapanesePrompts = new()
    {
        ["Role_Default"] = "私はシニアバックエンド開発者 .NET です。",
        ["Context_Default"] = "コンテキスト: [プロジェクト、状況、または目標を簡潔に説明してください]。",
        ["Task_Default"] = "タスク: [正確に何を得る必要があるかを明確に記述してください]。",
        ["Constraints_Default"] = "制約: [許可されていないこと、テクノロジー、スタイル、形式の要件]。",
        ["OutputFormat_Default"] = "出力形式: [結果が必要な形式 - コード、テーブル、リスト、JSON、マークダウンなど]。",
        ["QualityCriteria_Default"] = "品質基準: [どのような兆候で結果を「成功」と見なしますか]。"
    };

    private static readonly Dictionary<string, string> KoreanPrompts = new()
    {
        ["Role_Default"] = "저는 시니어 백엔드 개발자 .NET입니다.",
        ["Context_Default"] = "컨텍스트: [프로젝트, 상황 또는 목표를 간략하게 설명하십시오].",
        ["Task_Default"] = "작업: [정확히 무엇을 얻어야 하는지 명확하게 명시하십시오].",
        ["Constraints_Default"] = "제약 조건: [허용되지 않는 것, 기술, 스타일, 형식 요구 사항].",
        ["OutputFormat_Default"] = "출력 형식: [결과가 필요한 형식 - 코드, 테이블, 목록, JSON, 마크다운 등].",
        ["QualityCriteria_Default"] = "품질 기준: [어떤 징후로 결과를 '성공적'이라고 간주합니까]."
    };

    private static readonly Dictionary<string, string> HindiPrompts = new()
    {
        ["Role_Default"] = "मैं एक सीनियर बैकएंड डेवलपर .NET हूँ।",
        ["Context_Default"] = "संदर्भ: [परियोजना, स्थिति या लक्ष्य का संक्षिप्त विवरण दें]。",
        ["Task_Default"] = "कार्य: [स्पष्ट रूप से बताएं कि वास्तव में क्या प्राप्त करना है]。",
        ["Constraints_Default"] = "बाधाएँ: [क्या अनुमत नहीं है, प्रौद्योगिकियों, शैली, प्रारूप के लिए आवश्यकताएँ]。",
        ["OutputFormat_Default"] = "आउटपुट प्रारूप: [किस रूप में परिणाम की आवश्यकता है - कोड, तालिका, सूची, JSON, मार्कडाउन, आदि]。",
        ["QualityCriteria_Default"] = "गुणवत्ता मानदंड: [किन संकेतों से आप परिणाम को 'सफल' मानते हैं]।"
    };

    private static readonly Dictionary<string, string> ArabicPrompts = new()
    {
        ["Role_Default"] = "أنا مطور خلفي أول .NET.",
        ["Context_Default"] = "السياق: [وصف موجز للمشروع أو الموقف أو الهدف].",
        ["Task_Default"] = "المهمة: [صياغة واضحة لما يجب الحصول عليه بالضبط].",
        ["Constraints_Default"] = "القيود: [ما هو غير مسموح به، متطلبات التقنيات، النمط، التنسيق].",
        ["OutputFormat_Default"] = "تنسيق الإخراج: [الشكل الذي يجب أن يكون عليه الناتج - كود، جدول، قائمة، JSON، Markdown، إلخ.].",
        ["QualityCriteria_Default"] = "معايير الجودة: [بأي علامات تعتبر النتيجة 'ناجحة']."
    };

    private static readonly Dictionary<string, string> TurkishPrompts = new()
    {
        ["Role_Default"] = "Ben Kıdemli Backend Geliştirici .NET'im.",
        ["Context_Default"] = "Bağlam: [projeyi, durumu veya hedefi kısaca açıklayın].",
        ["Task_Default"] = "Görev: [tam olarak ne elde edilmesi gerektiğini açıkça belirtin].",
        ["Constraints_Default"] = "Kısıtlamalar: [neyin izin verilmediği, teknolojiler, stil, format gereksinimleri].",
        ["OutputFormat_Default"] = "Çıktı Formatı: [sonucun hangi biçimde olması gerektiği - kod, tablo, liste, JSON, markdown vb.].",
        ["QualityCriteria_Default"] = "Kalite Kriterleri: [sonucu 'başarılı' saydığınız işaretler nelerdir]."
    };

    private static readonly Dictionary<string, string> PolishPrompts = new()
    {
        ["Role_Default"] = "Jestem Starszym Programistą Backend .NET.",
        ["Context_Default"] = "Kontekst: [krótko opisz projekt, sytuację lub cel].",
        ["Task_Default"] = "Zadanie: [jasno sformułuj, co dokładnie należy uzyskać].",
        ["Constraints_Default"] = "Ograniczenia: [co jest niedozwolone, wymagania dotyczące technologii, stylu, formatu].",
        ["OutputFormat_Default"] = "Format Wyjścia: [w jakiej formie potrzebny jest wynik - kod, tabela, lista, JSON, markdown itp.].",
        ["QualityCriteria_Default"] = "Kryteria Jakości: [po jakich znakach uważasz wynik za 'udany']."
    };

    private static readonly Dictionary<string, string> UkrainianPrompts = new()
    {
        ["Role_Default"] = "Я Senior Backend Розробник .NET.",
        ["Context_Default"] = "Контекст: [коротко опишіть проект, ситуацію або мету].",
        ["Task_Default"] = "Завдання: [чітко сформулюйте, що саме потрібно отримати].",
        ["Constraints_Default"] = "Обмеження: [що не дозволено, вимоги до технологій, стилю, формату].",
        ["OutputFormat_Default"] = "Формат Виводу: [в якому вигляді потрібен результат - код, таблиця, список, JSON, markdown тощо].",
        ["QualityCriteria_Default"] = "Критерії Якості: [за якими ознаками ви вважаєте результат 'успішним']."
    };

    private static readonly Dictionary<string, string> DutchPrompts = new()
    {
        ["Role_Default"] = "Ik ben Senior Backend Ontwikkelaar .NET.",
        ["Context_Default"] = "Context: [beschrijf kort het project, de situatie of het doel].",
        ["Task_Default"] = "Taak: [formuleer duidelijk wat precies moet worden verkregen].",
        ["Constraints_Default"] = "Beperkingen: [wat niet is toegestaan, vereisten voor technologieën, stijl, formaat].",
        ["OutputFormat_Default"] = "Uitvoerformaat: [in welke vorm het resultaat nodig is - code, tabel, lijst, JSON, markdown, enz.].",
        ["QualityCriteria_Default"] = "Kwaliteitscriteria: [aan welke tekenen u het resultaat als 'succesvol' beschouwt]."
    };

    private static readonly Dictionary<string, string> HebrewPrompts = new()
    {
        ["Role_Default"] = "אני מפתח בכיר ב-Backend .NET.",
        ["Context_Default"] = "הקשר: [תאר בקצרה את הפרויקט, המצב או המטרה].",
        ["Task_Default"] = "משימה: [נסח בבירור מה בדיוק צריך להשיג].",
        ["Constraints_Default"] = "אילוצים: [מה אסור, דרישות לטכנולוגיות, סגנון, פורמט].",
        ["OutputFormat_Default"] = "פורמט פלט: [באיזו צורה נדרשת התוצאה - קוד, טבלה, רשימה, JSON, Markdown וכו'].",
        ["QualityCriteria_Default"] = "קריטריוני איכות: [לפי אילו סימנים אתה מחשיב את התוצאה 'מוצלחת']."
    };

    private static readonly Dictionary<Language, Dictionary<string, string>> Prompts;

    static StaticPrompts()
    {
        Prompts = new Dictionary<Language, Dictionary<string, string>>
        {
            [Language.English] = EnglishPrompts,
            [Language.Russian] = RussianPrompts,
            [Language.Spanish] = SpanishPrompts,
            [Language.ChineseSimplified] = ChineseSimplifiedPrompts,
            [Language.ChineseTraditional] = ChineseTraditionalPrompts,
            [Language.German] = GermanPrompts,
            [Language.French] = FrenchPrompts,
            [Language.Portuguese] = PortuguesePrompts,
            [Language.Italian] = ItalianPrompts,
            [Language.Japanese] = JapanesePrompts,
            [Language.Korean] = KoreanPrompts,
            [Language.Hindi] = HindiPrompts,
            [Language.Arabic] = ArabicPrompts,
            [Language.Turkish] = TurkishPrompts,
            [Language.Polish] = PolishPrompts,
            [Language.Ukrainian] = UkrainianPrompts,
            [Language.Dutch] = DutchPrompts,
            [Language.Hebrew] = HebrewPrompts
        };

        // All other languages will default to English
        foreach (Language lang in Enum.GetValues(typeof(Language)))
        {
            Prompts.TryAdd(lang, EnglishPrompts);
        }
    }

    public static Dictionary<string, string> GetDefaults(string cultureName)
    {
        var language = cultureName.ToLanguage();
        var prompts = Prompts[language];
        return prompts;
    }
}
