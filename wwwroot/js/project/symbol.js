
const info_symbol = document.querySelectorAll(".info_symbol");
const info_box = document.querySelectorAll(".info_box");

eventHandler(info_symbol, info_box, "mouseover", "show", "multiple")
eventHandler(info_symbol, info_box, "mouseleave", "hide", "multiple")

const stock_chart = document.getElementById('stock_chart');
const stock_chart1 = new Chart(stock_chart, {
    type: "line",
    data: {
        labels: ['Red', 'Blue', 'Yellow', 'Green', 'Purple', 'Orange'],
        datasets: [{
            label: '# of Votes',
            data: [12, 19, 3, 5, 2, 3],
            backgroundColor: [
                'rgba(255, 99, 132, 1)',
                'rgba(54, 162, 235, 1)',
                'rgba(255, 206, 86, 1)',
                'rgba(75, 192, 192, 1)',
                'rgba(153, 102, 255, 1)',
                'rgba(255, 159, 64, 1)'
            ],
            borderColor: [
                'rgba(255, 99, 132, 1)',
                'rgba(54, 162, 235, 1)',
                'rgba(255, 206, 86, 1)',
                'rgba(75, 192, 192, 1)',
                'rgba(153, 102, 255, 1)',
                'rgba(255, 159, 64, 1)'
            ],
            borderWidth: 1
        }]
    },
    options: chartConfig(),
});

const chart_margin = document.getElementById('chart_margin');
const chart_margin1 = new Chart(chart_margin, {
    type: "bar",
    data: {
        labels: [2015, 2016, 2017, 2018, 2019, 2020, 2021],
        datasets: [{
            label: "Gross Margin",
            data: [2015, 2016, 2017, 2018, 2019, 2020, 2021],
            backgroundColor: "rgb(0, 110, 255)",
        }, {
            label: "Operating Margin",
            data: [2015, 2016, 2017, 2018, 2019, 2020, 2021],
            backgroundColor: "rgb(20, 150, 255)",
        }, {
            label: "Profit Margin",
            data: [2015, 2016, 2017, 2018, 2019, 2020, 2021],
            backgroundColor: "rgb(20, 200, 240)",
        },],
    },
    options: chartConfig(),
});

const chart_ratio = document.getElementById('chart_ratio');
const chart_ratio1 = new Chart(chart_ratio, {
    type: 'line',
    data: {
        labels: [2015, 2016, 2017, 2018, 2019, 2020, 2021],
        datasets: [{
            label: "EPS",
            data: [2015, 2016, 2017, 2018, 2019, 2020, 2021],
            backgroundColor: "rgb(110, 255, 255)",
            borderColor: "rgb(110, 255, 255, 0.3)",
        }, {
            label: "P/B Ratio",
            data: [2014, 2015, 2016, 2017, 2018, 2019, 2021],
            backgroundColor: "rgb(110, 255, 0)",
            borderColor: "rgb(110, 255, 0, 0.3)",
        }, {
            label: "P/E Ratio",
            data: [1, 2, 3, 4, 5, 6, 7],
            backgroundColor: "rgb(138, 48, 255)",
            borderColor: "rgb(138, 48, 255, 0.3)",
            yAxisID: "right",
        },],
    },
    options: chartConfig("normal", true, "rgb(138, 48, 255)"),
});

const chart_dividend = document.getElementById('chart_dividend');
const chart_dividend1 = new Chart(chart_dividend, {
    type: 'line',
    data: {
        labels: [2014, 2015, 2016, 2017, 2018, 2019, 2021],
        datasets: [{
            label: "Dividend in %",
            data: [2014, 2015, 2016, 2017, 2018, 2019, 2021],
            backgroundColor: "rgb(20, 150, 255)",
            borderColor: "rgb(20, 150, 255, 0.3)",
            yAxisID: "right",
        }, {
            label: "Payout Ratio",
            data: [2015, 2016, 2017, 2018, 2019, 2020, 2021],
            backgroundColor: "rgb(144, 0, 255)",
            borderColor: "rgb(144, 0, 255, 0.4)",
        }]
    },
    options: chartConfig("pct", true, "rgb(20, 150, 255)"),
});