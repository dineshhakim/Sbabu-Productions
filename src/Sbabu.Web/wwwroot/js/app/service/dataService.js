var url = "http://localhost:53546/api/PortfoliosApi/1";


function getPhotos($http) {
    $http.get("/api/PortfoliosApi/1").success(function (data) {
        $scope.portfolios = data;
    }).error(function (data) {
        alert(data);
    });
}
//function getBio($sce) {
//    var msg = 'Senior Software Developer with 5 years of experience. Developing project using asp.net web-forms, MVC and Web API(Restful) with C# and SQL server. I am experienced in developing enterprise level software specialized in Banking and HR Software. Experienced of managing entire software development cycle including \n requirement analysis, diagramming, design, development, testing and deployment. Working in agile team, I developed my programming skills, communication skills and team work. Experienced in delegation of job to the team members. Motivated to be good programmer and built a strong team and develop interesting and creative projects.';
//    msg = msg.replace(/\. /g, ".\n");
//    msg = msg.replace(/✔/g, "\n <i class='fa fa-arrow-right'></i> ");
//    msg = $sce.trustAsHtml(msg);
//    return msg;
//}
 
//function getWhatIdo() {
//    var data =
//        [
//            { name: 'WebSite Development' },
//            { name: 'Application Development' },
//            { name: 'Full Stack Development' }
//        ];
//    return data;
//}
//function getAboutMe($sce) {
//    var data =
//        {
//            name: "Dinesh Karn",
//            dob: "01 Sep 1989",
//            phone: "+1-510-660-8499",
//            email: "kumardinesh.karn@gmail.com",
//            description: getBio($sce),
//            whatIDo: getWhatIdo()
//        };
//    return data;
//}

