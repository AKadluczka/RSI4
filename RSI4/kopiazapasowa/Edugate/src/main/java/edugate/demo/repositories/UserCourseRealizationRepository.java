package edugate.demo.repositories;

import org.springframework.data.jpa.repository.JpaRepository;

import edugate.demo.model.UserCourseRealization;

public interface UserCourseRealizationRepository extends JpaRepository<UserCourseRealization,Long> {
}
