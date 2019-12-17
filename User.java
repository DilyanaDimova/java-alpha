package OOP.OOPTelerikAcademyAlphaProject.HospitalManagementSystem;

public class User {
    private long id;
    private String firstName;
    private String lastName;
    private String gender;
    private String email;

    public User() {

    }

    public User(long id, String firstName, String lastName, String gender, String email) {
        this.id = id;
        this.firstName = firstName;
        this.lastName = lastName;
        this.gender = gender;
        this.email = email;
    }

    private void setId(long id) {
        this.id = id;
    }

    private void setFirstName(String firstName) {
        this.firstName = firstName;
    }

    private void setLastName(String lastName) {
        this.lastName = lastName;
    }

    private void setGender(String gender) {
        this.gender = gender;
    }

    private void setEmail(String email) {
        this.email = email;
    }

    public long getId() {
        return this.id;
    }

    public String getFirstName() {
        return this.firstName;
    }

    public String getLastName() {
        return this.lastName;
    }

    public String getGender() {
        return this.gender;
    }

    public String getEmail() {
        return this.email;
    }

}
