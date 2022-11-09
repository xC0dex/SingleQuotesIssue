window.singleQuotesIssue = function () {
    const paragraph = document.getElementsByTagName('p')[0];
    const rawUserData = paragraph.getAttribute('data-single-quotes');
    const user = JSON.parse(rawUserData);
    console.log(user);
}