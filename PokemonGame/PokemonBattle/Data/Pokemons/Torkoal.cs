using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Torkoal : Pokemon
	{
		public override string Name => "Torkoal";
		public override List<Ability> AvailableAbilities => new() {new Whitesmoke(), new Drought() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Shellarmor() };
		public override Stats BaseStats => new Stats(70, 85, 140, 85, 70, 20);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Fire };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Smog(), new Ember() },
			[4] = new List<Move>() { new Withdraw() },
			[8] = new List<Move>() { new Rapidspin() },
			[12] = new List<Move>() { new Smokescreen() },
			[16] = new List<Move>() { new Clearsmog() },
			[20] = new List<Move>() { new Flamewheel() },
			[24] = new List<Move>() { new Protect() },
			[28] = new List<Move>() { new Lavaplume() },
			[32] = new List<Move>() { new Bodyslam() },
			[36] = new List<Move>() { new Irondefense() },
			[40] = new List<Move>() { new Flamethrower() },
			[44] = new List<Move>() { new Curse() },
			[48] = new List<Move>() { new Heatwave() },
			[52] = new List<Move>() { new Amnesia() },
			[56] = new List<Move>() { new Inferno() },
			[60] = new List<Move>() { new Shellsmash() },
			[64] = new List<Move>() { new Eruption() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Amnesia(), new Attract(), new Bodypress(), new Bodyslam(), new Bulldoze(), new Burningjealousy(), new Doubleteam(), new Earthpower(), new Earthquake(), new Endure(), new Explosion(), new Facade(), new Fireblast(), new Firespin(), new Flamethrower(), new Gigaimpact(), new Gyroball(), new Heatcrash(), new Heatwave(), new Hiddenpower(), new Hyperbeam(), new Irondefense(), new Irontail(), new Overheat(), new Protect(), new Rest(), new Rockslide(), new Rocksmash(), new Rocktomb(), new Round(), new Scorchingsands(), new Selfdestruct(), new Sleeptalk(), new Sludgebomb(), new Snore(), new Solarbeam(), new Stealthrock(), new Stompingtantrum(), new Stoneedge(), new Strength(), new Substitute(), new Sunnyday(), new Superpower(), new Swagger(), new Weatherball(), new Willowisp() };
		public override List<Move> EggMoves => new List<Move>() { new Ancientpower(), new Clearsmog(), new Eruption(), new Fissure(), new Flail(), new Skullbash(), new Superpower(), new Yawn() };
		public override int Weight => 804;
		public override int ExpYield => 165;
		public override int CatchRate => 90;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 0,
			[Stat.Defense] = 2,
			[Stat.SpecialAttack] = 0,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 0
		};
	}
}