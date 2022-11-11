const financial_display = document.querySelectorAll(".financial_display")
const financial_normal = document.getElementById("financial_normal")
const financial_color = document.getElementById("financial_color")

const financials_row = document.querySelectorAll(".financials_row")
const financial_control = document.querySelectorAll(".financial_control")
const financials_view = document.querySelectorAll(".financials_view")

financials_view[0].classList.add("active");

activeLooper(financial_control, "navtabs", financials_view)
activeLooper(financial_display, "navigation")


//Color View
function financialTheme(color) {
    financials_row.forEach(cell => {
        let children = cell.getElementsByClassName("financials_text")
        convert(children, "normal")
    
        //Average of Financial Row
        let childSum = 0;
        
        for(let i = 0; i < children.length; i++) {
            childSum += parseInt(children[i].innerHTML);
        }
        const childAverage = childSum / children.length
    
        //Color each Cell based on distance to average
        for (child of children) {
            if (color) {
                if (parseInt(child.innerHTML) >= childAverage) {
                    child.style.background = "#00ff00"
                } else {
                    child.style.background = "#ff0000"
                }
                child.style.color = "white"; 
            }
            else {
                child.style.background = "var(--color-theme)"
                child.style.color = "var(--color-reverse)"
            }
        }
        convert(children, "dollar")
    })
}

financial_normal.addEventListener("click", () => {
    financialTheme(false)
})
financial_color.addEventListener("click", () => {
    financialTheme(true)
})




const dollar = document.querySelectorAll(".dollar");
//Dollar Formatter
function convert(objects, to) {
    var formatter;
    if (to == "dollar") {
        formatter = new Intl.NumberFormat('en-US', {
            style: 'currency',
            currency: 'USD',
            maximumFractionDigits: 3, 
        });
        objects.forEach(object => {
            x = formatter.format(object.innerHTML)
            object.innerHTML = x
        })
    } else if (to == "normal") {
        objects.forEach(object => {
            let string = object.innerHTML
            string = string.replace("$", "").replace(".00", "").replace(",", "")
            let result = parseFloat(string)
            object.innerHTML = result
        })
    }
}







