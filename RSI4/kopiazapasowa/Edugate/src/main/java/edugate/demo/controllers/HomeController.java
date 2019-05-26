package edugate.demo.controllers;

import edugate.demo.repositories.UsersRepository;
import edugate.demo.security.SecurityService;
import edugate.demo.services.UserService;
import org.slf4j.Logger;
import org.slf4j.LoggerFactory;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.security.core.Authentication;
import org.springframework.security.core.context.SecurityContextHolder;
import org.springframework.stereotype.Controller;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RequestMethod;
import org.springframework.web.bind.annotation.ResponseBody;
import org.springframework.web.servlet.ModelAndView;

import java.security.Principal;

@Controller
public class HomeController {

	@Autowired
	SecurityService securityService;
	@Autowired
	UserService userService;
	@Autowired
	UsersRepository usersRepository;

	private static final Logger logger = LoggerFactory.getLogger(HomeController.class);




	@RequestMapping(value="/home")
	public ModelAndView homeLink(Principal principal) {

		ModelAndView mv = new ModelAndView("home");
		mv.addObject("currentUser",usersRepository.findByLogin(principal.getName()).getiduser());
		System.out.println("homePage");
		return mv;
	}
	
	@RequestMapping(value="/profileLink")
	public String profileLink() {
	
		System.out.println("profileLink");
		return "profile";
	}
	
	@RequestMapping(value="/departmentLink")
	public String addDepartmentLink() {
	
		System.out.println("departmentLink");
		return "adddepartment";
	}
	
	@RequestMapping(value="/schoolLink")
	public String addSchoolLink() {
	
		System.out.println("schoolLink");
		return "addschool";
	}
	
	@RequestMapping(value="/courseLink")
	public String addCourseLink() {
	
		System.out.println("courseLink");
		return "addcourse";
	}
}
