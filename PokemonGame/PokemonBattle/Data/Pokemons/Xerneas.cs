using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Xerneas : Pokemon
	{
		public override string Name => "Xerneas";
		public override List<Ability> AvailableAbilities => new() {new Fairyaura() };
		public override Stats BaseStats => new Stats(126, 131, 95, 99, 131, 98);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Slow;
		public override List<PokemonType> Types => new() {PokemonType.Fairy };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Tackle(), new Gravity() },
			[5] = new List<Move>() { new Lightscreen() },
			[10] = new List<Move>() { new Aurorabeam() },
			[15] = new List<Move>() { new Naturepower() },
			[20] = new List<Move>() { new Nightslash() },
			[25] = new List<Move>() { new Aromatherapy() },
			[30] = new List<Move>() { new Psychup() },
			[35] = new List<Move>() { new Hornleech() },
			[40] = new List<Move>() { new Mistyterrain() },
			[45] = new List<Move>() { new Ingrain() },
			[50] = new List<Move>() { new Takedown() },
			[55] = new List<Move>() { new Geomancy() },
			[60] = new List<Move>() { new Moonblast() },
			[65] = new List<Move>() { new Healpulse() },
			[70] = new List<Move>() { new Megahorn() },
			[75] = new List<Move>() { new Closecombat() },
			[80] = new List<Move>() { new Outrage() },
			[85] = new List<Move>() { new Gigaimpact() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Bodyslam(), new Calmmind(), new Closecombat(), new Dazzlinggleam(), new Drainingkiss(), new Endure(), new Facade(), new Flashcannon(), new Focusblast(), new Gigaimpact(), new Grassknot(), new Hail(), new Hiddenpower(), new Hyperbeam(), new Hypervoice(), new Lightscreen(), new Megahorn(), new Mistyexplosion(), new Mistyterrain(), new Outrage(), new Playrough(), new Protect(), new Psychic(), new Psyshock(), new Raindance(), new Reflect(), new Rest(), new Rockslide(), new Round(), new Sleeptalk(), new Smartstrike(), new Snore(), new Substitute(), new Sunnyday(), new Swift(), new Terrainpulse(), new Thunder(), new Thunderbolt(), new Thunderwave(), new Wonderroom(), new Zenheadbutt() };
		public override int Weight => 2150;
		public override int ExpYield => 340;
		public override int CatchRate => 45;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 3,
			[Stat.Attack] = 0,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 0,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 0
		};
	}
}