package imdb.controller;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Controller;
import org.springframework.ui.Model;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.PathVariable;
import org.springframework.web.bind.annotation.PostMapping;
import imdb.bindingModel.FilmBindingModel;
import imdb.entity.Film;
import imdb.repository.FilmRepository;

import java.util.List;

@Controller
public class FilmController {

	private final FilmRepository filmRepository;

	@Autowired
	public FilmController(FilmRepository filmRepository, FilmRepository filmRepository1) {
		//TODO: Implement me ...
		this.filmRepository = filmRepository1;
	}

	@GetMapping("/")
	public String index(Model model) {
		List<Film> films = this.filmRepository.findAll();

		model.addAttribute("view","film/index");
		model.addAttribute("films",films);

		return "base-layout";
	}

	@GetMapping("/create")
	public String create(Model model) {
		model.addAttribute("view","film/create");

		return "base-layout";
	}

	@PostMapping("/create")
	public String createProcess(Model model, FilmBindingModel filmBindingModel) {
		//We get the film's data from the form by using binding model
		//then we save this data to the filmEntity variable.
		Film filmEntity = new Film(
				filmBindingModel.getName(),
				filmBindingModel.getGenre(),
				filmBindingModel.getDirector(),
				filmBindingModel.getYear()
		);

		//We save this film in the databse using filmRepository.
		this.filmRepository.saveAndFlush(filmEntity);
		//Finally we redirect to Home Page.
		return "redirect:/";
	}

	@GetMapping("/edit/{id}")
	public String edit(Model model, @PathVariable int id) {
		//We get the film from the database and save it in the database.
		Film filmEnity = this.filmRepository.findOne(id);

		//We check if it is null
		if (filmEnity == null) {
			return "redirect:/";
		}

		//And if it is not null we render the view with the film
		model.addAttribute("view","film/edit");
		model.addAttribute("film",filmEnity);

		return "base-layout";
	}

	@PostMapping("/edit/{id}")
	public String editProcess(Model model, @PathVariable int id, FilmBindingModel filmBindingModel) {

		//We find the film from the databse by id and store it in filmFromDb variable.
		Film filmFromDb = this.filmRepository.findOne(id);

		//We check if it is null
		if (filmFromDb == null) {
			return "redirect:/";
		}

		//and if it is not null we change the name of the film in the database
		//with the name of the film form the form
		filmFromDb.setName(filmBindingModel.getName());
		//We do this with the genre,
		filmFromDb.setGenre(filmBindingModel.getGenre());
		//And with the director,
		filmFromDb.setDirector(filmBindingModel.getDirector());
		//And with the year too.
		filmFromDb.setYear(filmBindingModel.getYear());

		//Then we save the changes in the database.
		this.filmRepository.saveAndFlush(filmFromDb);

		//And finally we redirect to Home Page.
		return "redirect:/";
	}

	@GetMapping("/delete/{id}")
	public String delete(Model model, @PathVariable int id) {
		//We get the film from the database and save it in the database.
		Film filmEnity = this.filmRepository.findOne(id);

		//We check if it is null
		if (filmEnity == null) {
			return "redirect:/";
		}

		//And if it is not null we render the view with the film
		model.addAttribute("view","film/delete");
		model.addAttribute("film",filmEnity);

		return "base-layout";
	}

	@PostMapping("/delete/{id}")
	public String deleteProcess(@PathVariable int id) {
		//We find the film n the databse
		Film filmFromDb = this.filmRepository.findOne(id);

		//We check if it is not null
		if (filmFromDb == null) {
			return "redirect:/";
		}

		//And if it is not null we delete this film from the database.
		this.filmRepository.delete(filmFromDb);
		return "redirect:/";
	}
}
