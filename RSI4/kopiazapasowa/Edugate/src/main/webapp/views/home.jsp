<%@ page language="java" contentType="text/html; charset=UTF-8"%>
<%@ page import="java.text.*,java.util.*" %>

<head>
<link href="/css/bootstrap.min.css" rel="stylesheet">
<link href="/css/Home.css" rel="stylesheet">
<link href="css/star.css" rel="stylesheet>
</head>
<body>

<%@include file="header.jsp" %>
<% Integer username = (Integer) request.getAttribute("currentUser");  %>
            <div className="home-container">
                <div className="container">
                	<div>
          				<h2><%=username%></h2>
	            				<a href="courseLink"> Dodaj kurs </a>
	            				<a href="schoolLink">Dodaj szkołę</a>
	            				<a href="departmentLink">Dodaj wydział</a>
	            				<a href="profileLink">Profil</a>
        			</div>
                </div>
            </div>
<div class="rating">
	<span id="1" onclick="setgold(1)">☆</span><span id="2" onclick="setgold(2)">☆</span><span id="3" onclick="setgold(3)">☆</span><span id="4" onclick="setgold(4)">☆</span><span id="5" onclick="setgold(5)">☆</span>
</div>
<script>
	function setgold(id) {
		var i;
		for (i=1;i<=id;i++) {
			document.getElementById(i).style.color = "gold";
		}
	}
</script>

</body>
</html>

           