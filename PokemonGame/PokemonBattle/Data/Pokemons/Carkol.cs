using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Carkol : Pokemon
	{
		public override string Name => "Carkol";
		public override List<Ability> AvailableAbilities => new() {new Steamengine(), new Flamebody() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Flashfire() };
		public override Stats BaseStats => new Stats(80, 60, 90, 60, 70, 50);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Parabolic;
		public override List<PokemonType> Types => new() {PokemonType.Rock, PokemonType.Fire };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[0] = new List<Move>() { new Flamecharge() },
			[1] = new List<Move>() { new Flamecharge(), new Tackle(), new Smokescreen(), new Rapidspin(), new Smackdown() },
			[15] = new List<Move>() { new Rockpolish() },
			[20] = new List<Move>() { new Ancientpower() },
			[27] = new List<Move>() { new Incinerate() },
			[35] = new List<Move>() { new Stealthrock() },
			[41] = new List<Move>() { new Heatcrash() },
			[48] = new List<Move>() { new Rockblast() },
			[55] = new List<Move>() { new Burnup() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Attract(), new Bodypress(), new Dig(), new Endure(), new Facade(), new Fireblast(), new Firespin(), new Flamethrower(), new Flareblitz(), new Gyroball(), new Heatcrash(), new Heatwave(), new Heavyslam(), new Hiddenpower(), new Highhorsepower(), new Irondefense(), new Ironhead(), new Meteorbeam(), new Overheat(), new Protect(), new Reflect(), new Rest(), new Rockblast(), new Rockslide(), new Rocktomb(), new Round(), new Sandstorm(), new Sandtomb(), new Scald(), new Scorchingsands(), new Selfdestruct(), new Sleeptalk(), new Snore(), new Spikes(), new Stealthrock(), new Stoneedge(), new Substitute(), new Willowisp() };
		public override int Weight => 780;
		public override int ExpYield => 144;
		public override int CatchRate => 120;
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