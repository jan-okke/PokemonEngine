using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Banette : Pokemon
	{
		public override string Name => "Banette";
		public override List<Ability> AvailableAbilities => new() {new Insomnia(), new Frisk() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Cursedbody() };
		public override Stats BaseStats => new Stats(64, 115, 65, 65, 83, 63);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Fast;
		public override List<PokemonType> Types => new() {PokemonType.Ghost };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Phantomforce(), new Knockoff(), new Screech(), new Nightshade(), new Spite() },
			[4] = new List<Move>() { new Screech() },
			[7] = new List<Move>() { new Nightshade() },
			[10] = new List<Move>() { new Spite() },
			[13] = new List<Move>() { new Shadowsneak() },
			[16] = new List<Move>() { new Willowisp() },
			[19] = new List<Move>() { new Painsplit() },
			[22] = new List<Move>() { new Hex() },
			[26] = new List<Move>() { new Curse() },
			[30] = new List<Move>() { new Shadowball() },
			[34] = new List<Move>() { new Roleplay() },
			[40] = new List<Move>() { new Suckerpunch() },
			[46] = new List<Move>() { new Knockoff() },
			[52] = new List<Move>() { new Grudge() },
			[58] = new List<Move>() { new Trick() },
			[64] = new List<Move>() { new Phantomforce() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Allyswitch(), new Attract(), new Calmmind(), new Chargebeam(), new Confide(), new Darkpulse(), new Dazzlinggleam(), new Doubleteam(), new Dreameater(), new Embargo(), new Endure(), new Facade(), new Flash(), new Fling(), new Foulplay(), new Frustration(), new Gigaimpact(), new Gunkshot(), new Hiddenpower(), new Hyperbeam(), new Icywind(), new Infestation(), new Knockoff(), new Magiccoat(), new Magicroom(), new Painsplit(), new Payback(), new Protect(), new Psychic(), new Psychup(), new Raindance(), new Rest(), new Return(), new Roleplay(), new Round(), new Shadowball(), new Shadowclaw(), new Shockwave(), new Skillswap(), new Sleeptalk(), new Snatch(), new Snore(), new Spite(), new Substitute(), new Sunnyday(), new Swagger(), new Taunt(), new Telekinesis(), new Thief(), new Throatchop(), new Thunder(), new Thunderbolt(), new Thunderwave(), new Torment(), new Trick(), new Trickroom(), new Willowisp() };
		public override int Weight => 125;
		public override int ExpYield => 159;
		public override int CatchRate => 45;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 2,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 0,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 0
		};
	}
}