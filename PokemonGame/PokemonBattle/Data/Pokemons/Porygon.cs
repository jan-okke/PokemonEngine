using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Porygon : Pokemon
	{
		public override string Name => "Porygon";
		public override List<Ability> AvailableAbilities => new() {new Trace(), new Download() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Analytic() };
		public override Stats BaseStats => new Stats(65, 60, 70, 40, 85, 75);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Normal };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Tackle(), new Conversion() },
			[5] = new List<Move>() { new Recycle() },
			[10] = new List<Move>() { new Magnetrise() },
			[15] = new List<Move>() { new Thundershock() },
			[20] = new List<Move>() { new Psybeam() },
			[25] = new List<Move>() { new Conversion2() },
			[30] = new List<Move>() { new Agility() },
			[35] = new List<Move>() { new Recover() },
			[40] = new List<Move>() { new Discharge() },
			[45] = new List<Move>() { new Triattack() },
			[50] = new List<Move>() { new Magiccoat() },
			[55] = new List<Move>() { new Lockon() },
			[60] = new List<Move>() { new Zapcannon() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Aerialace(), new Agility(), new Allyswitch(), new Blizzard(), new Chargebeam(), new Doubleteam(), new Dreameater(), new Eerieimpulse(), new Electroweb(), new Endure(), new Facade(), new Flash(), new Foulplay(), new Gigaimpact(), new Guardswap(), new Hiddenpower(), new Hyperbeam(), new Icebeam(), new Icywind(), new Irontail(), new Powerswap(), new Protect(), new Psychic(), new Psychup(), new Psyshock(), new Raindance(), new Recycle(), new Rest(), new Round(), new Shadowball(), new Shockwave(), new Sleeptalk(), new Snore(), new Solarbeam(), new Speedswap(), new Substitute(), new Sunnyday(), new Swagger(), new Swift(), new Thief(), new Thunder(), new Thunderbolt(), new Thunderwave(), new Triattack(), new Trick(), new Trickroom(), new Wonderroom(), new Zenheadbutt() };
		public override int Weight => 365;
		public override int ExpYield => 79;
		public override int CatchRate => 45;
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