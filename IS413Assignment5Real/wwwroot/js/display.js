/*function display_info(){
    let my_num = event.target.id
  
    document.getElementById("test").innerHTML = my_num
    .forEach(item => {
    item.addEventListener('hover', event => {
        document.getElementById("test").innerHTML = "works"
    });
});

};*/

document.querySelectorAll('#booktable tr')
    .forEach(e => e.addEventListener("mouseover", function () {
        // get element id and display assosciated div
        let detail_id = "details" + e.id
        document.getElementById(detail_id).style = "display:block"
    }));

document.querySelectorAll('#booktable tr')
    .forEach(e => e.addEventListener("mouseout", function () {
        // get element id and display assosciated div
        let detail_id = "details" + e.id
        document.getElementById(detail_id).style = "display:none"
    }));


function highlighter() {
    let pageNum = document.getElementById("current_page").value;
    let pageguy = "pagenumber" + pageNum;
    document.getElementById(pageguy).style.color = 'lavender';
}
highlighter()