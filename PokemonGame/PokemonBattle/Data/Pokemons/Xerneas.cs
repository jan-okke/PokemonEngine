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
		public override List<Ability> AvailableAbilities => new() {new Abilities.Fairyaura() };
		public override Stats BaseStats => new Stats(126, 131, 95, 131, 98, 99);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Slow;
		public override List<PokemonType> Types => new() {PokemonType.Fairy };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Moves.Tackle(), new Moves.Gravity() },
			[5] = new List<Move>() { new Moves.Lightscreen() },
			[10] = new List<Move>() { new Moves.Aurorabeam() },
			[15] = new List<Move>() { new Moves.Naturepower() },
			[20] = new List<Move>() { new Moves.Nightslash() },
			[25] = new List<Move>() { new Moves.Aromatherapy() },
			[30] = new List<Move>() { new Moves.Psychup() },
			[35] = new List<Move>() { new Moves.Hornleech() },
			[40] = new List<Move>() { new Moves.Mistyterrain() },
			[45] = new List<Move>() { new Moves.Ingrain() },
			[50] = new List<Move>() { new Moves.Takedown() },
			[55] = new List<Move>() { new Moves.Geomancy() },
			[60] = new List<Move>() { new Moves.Moonblast() },
			[65] = new List<Move>() { new Moves.Healpulse() },
			[70] = new List<Move>() { new Moves.Megahorn() },
			[75] = new List<Move>() { new Moves.Closecombat() },
			[80] = new List<Move>() { new Moves.Outrage() },
			[85] = new List<Move>() { new Moves.Gigaimpact() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Moves.Bodyslam(), new Moves.Calmmind(), new Moves.Closecombat(), new Moves.Dazzlinggleam(), new Moves.Drainingkiss(), new Moves.Endure(), new Moves.Facade(), new Moves.Flashcannon(), new Moves.Focusblast(), new Moves.Gigaimpact(), new Moves.Grassknot(), new Moves.Hail(), new Moves.Hiddenpower(), new Moves.Hyperbeam(), new Moves.Hypervoice(), new Moves.Lightscreen(), new Moves.Megahorn(), new Moves.Mistyexplosion(), new Moves.Mistyterrain(), new Moves.Outrage(), new Moves.Playrough(), new Moves.Protect(), new Moves.Psychic(), new Moves.Psyshock(), new Moves.Raindance(), new Moves.Reflect(), new Moves.Rest(), new Moves.Rockslide(), new Moves.Round(), new Moves.Sleeptalk(), new Moves.Smartstrike(), new Moves.Snore(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Swift(), new Moves.Terrainpulse(), new Moves.Thunder(), new Moves.Thunderbolt(), new Moves.Thunderwave(), new Moves.Wonderroom(), new Moves.Zenheadbutt() };
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