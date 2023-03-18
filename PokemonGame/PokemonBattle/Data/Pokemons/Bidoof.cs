using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Bidoof : Pokemon
	{
		public override string Name => "Bidoof";
		public override List<Ability> AvailableAbilities => new() {new Simple(), new Unaware() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Moody() };
		public override Stats BaseStats => new Stats(59, 45, 40, 35, 40, 31);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Normal };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Tackle(), new Growl() },
			[5] = new List<Move>() { new Defensecurl() },
			[9] = new List<Move>() { new Rollout() },
			[13] = new List<Move>() { new Headbutt() },
			[17] = new List<Move>() { new Taunt() },
			[21] = new List<Move>() { new Yawn() },
			[25] = new List<Move>() { new Crunch() },
			[29] = new List<Move>() { new Takedown() },
			[33] = new List<Move>() { new Superfang() },
			[37] = new List<Move>() { new Swordsdance() },
			[41] = new List<Move>() { new Amnesia() },
			[45] = new List<Move>() { new Superpower() },
			[49] = new List<Move>() { new Curse() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Aquatail(), new Attract(), new Blizzard(), new Chargebeam(), new Confide(), new Covet(), new Cut(), new Dig(), new Doubleteam(), new Echoedvoice(), new Endure(), new Facade(), new Frustration(), new Grassknot(), new Hiddenpower(), new Icebeam(), new Icywind(), new Irontail(), new Lastresort(), new Pluck(), new Protect(), new Raindance(), new Rest(), new Return(), new Rocksmash(), new Round(), new Shadowball(), new Shockwave(), new Sleeptalk(), new Snore(), new Stealthrock(), new Substitute(), new Sunnyday(), new Superfang(), new Superpower(), new Swagger(), new Swordsdance(), new Taunt(), new Thief(), new Thunder(), new Thunderbolt(), new Thunderwave(), new Workup() };
		public override List<Move> EggMoves => new List<Move>() { new Aquatail(), new Defensecurl(), new Doubleedge(), new Furyswipes(), new Quickattack(), new Rollout(), new Skullbash() };
		public override int Weight => 200;
		public override int ExpYield => 50;
		public override int CatchRate => 255;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 1,
			[Stat.Attack] = 0,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 0,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 0
		};
	}
}