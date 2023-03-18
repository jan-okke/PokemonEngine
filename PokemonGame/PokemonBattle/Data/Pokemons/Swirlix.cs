using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Swirlix : Pokemon
	{
		public override string Name => "Swirlix";
		public override List<Ability> AvailableAbilities => new() {new Sweetveil() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Unburden() };
		public override Stats BaseStats => new Stats(62, 48, 66, 59, 57, 49);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Fairy };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Tackle(), new Sweetscent() },
			[3] = new List<Move>() { new Playnice() },
			[6] = new List<Move>() { new Fairywind() },
			[9] = new List<Move>() { new Aromatherapy() },
			[12] = new List<Move>() { new Drainingkiss() },
			[15] = new List<Move>() { new Faketears() },
			[18] = new List<Move>() { new Round() },
			[21] = new List<Move>() { new Stringshot() },
			[24] = new List<Move>() { new Cottonspore() },
			[27] = new List<Move>() { new Energyball() },
			[30] = new List<Move>() { new Wish() },
			[33] = new List<Move>() { new Playrough() },
			[36] = new List<Move>() { new Cottonguard() },
			[39] = new List<Move>() { new Endeavor() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Amnesia(), new Attract(), new Calmmind(), new Charm(), new Dazzlinggleam(), new Drainingkiss(), new Endure(), new Energyball(), new Facade(), new Faketears(), new Flamethrower(), new Helpinghand(), new Hiddenpower(), new Lightscreen(), new Mistyexplosion(), new Playrough(), new Protect(), new Psychic(), new Raindance(), new Rest(), new Round(), new Safeguard(), new Sleeptalk(), new Snore(), new Substitute(), new Sunnyday(), new Surf(), new Thief(), new Thunderbolt() };
		public override List<Move> EggMoves => new List<Move>() { new Afteryou(), new Copycat(), new Stickyweb(), new Yawn() };
		public override int Weight => 35;
		public override int ExpYield => 68;
		public override int CatchRate => 200;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 0,
			[Stat.Defense] = 1,
			[Stat.SpecialAttack] = 0,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 0
		};
	}
}