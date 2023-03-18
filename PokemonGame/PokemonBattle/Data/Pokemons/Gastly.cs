using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Gastly : Pokemon
	{
		public override string Name => "Gastly";
		public override List<Ability> AvailableAbilities => new() {new Levitate() };
		public override Stats BaseStats => new Stats(30, 35, 30, 100, 35, 80);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Parabolic;
		public override List<PokemonType> Types => new() {PokemonType.Ghost, PokemonType.Poison };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Lick(), new Confuseray() },
			[4] = new List<Move>() { new Hypnosis() },
			[8] = new List<Move>() { new Meanlook() },
			[12] = new List<Move>() { new Payback() },
			[16] = new List<Move>() { new Spite() },
			[20] = new List<Move>() { new Curse() },
			[24] = new List<Move>() { new Hex() },
			[28] = new List<Move>() { new Nightshade() },
			[32] = new List<Move>() { new Suckerpunch() },
			[36] = new List<Move>() { new Darkpulse() },
			[40] = new List<Move>() { new Shadowball() },
			[44] = new List<Move>() { new Destinybond() },
			[48] = new List<Move>() { new Dreameater() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Allyswitch(), new Attract(), new Corrosivegas(), new Darkpulse(), new Dazzlinggleam(), new Doubleteam(), new Dreameater(), new Endure(), new Energyball(), new Explosion(), new Facade(), new Firepunch(), new Foulplay(), new Gigadrain(), new Hex(), new Hiddenpower(), new Icepunch(), new Icywind(), new Payback(), new Poisonjab(), new Poltergeist(), new Protect(), new Psychic(), new Psychup(), new Raindance(), new Rest(), new Round(), new Scaryface(), new Selfdestruct(), new Shadowball(), new Skillswap(), new Skittersmack(), new Sleeptalk(), new Sludgebomb(), new Sludgewave(), new Snore(), new Substitute(), new Sunnyday(), new Swagger(), new Taunt(), new Thief(), new Thunderbolt(), new Thunderpunch(), new Torment(), new Toxic(), new Trick(), new Trickroom(), new Uproar(), new Venoshock(), new Willowisp(), new Wonderroom() };
		public override List<Move> EggMoves => new List<Move>() { new Astonish(), new Clearsmog(), new Disable(), new Firepunch(), new Grudge(), new Haze(), new Icepunch(), new Perishsong(), new Reflecttype(), new Scaryface(), new Smog(), new Thunderpunch() };
		public override int Weight => 1;
		public override int ExpYield => 62;
		public override int CatchRate => 190;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 0,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 1,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 0
		};
	}
}