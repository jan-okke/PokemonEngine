using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Coalossal : Pokemon
	{
		public override string Name => "Coalossal";
		public override List<Ability> AvailableAbilities => new() {new Steamengine(), new Flamebody() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Flashfire() };
		public override Stats BaseStats => new Stats(110, 80, 120, 80, 90, 30);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Parabolic;
		public override List<PokemonType> Types => new() {PokemonType.Rock, PokemonType.Fire };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[0] = new List<Move>() { new Tarshot() },
			[1] = new List<Move>() { new Tarshot(), new Flamecharge(), new Tackle(), new Smokescreen(), new Rapidspin(), new Smackdown() },
			[15] = new List<Move>() { new Rockpolish() },
			[20] = new List<Move>() { new Ancientpower() },
			[27] = new List<Move>() { new Incinerate() },
			[37] = new List<Move>() { new Stealthrock() },
			[45] = new List<Move>() { new Heatcrash() },
			[54] = new List<Move>() { new Rockblast() },
			[63] = new List<Move>() { new Burnup() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Attract(), new Bodypress(), new Bodyslam(), new Bulldoze(), new Dig(), new Earthpower(), new Earthquake(), new Endure(), new Facade(), new Fireblast(), new Firepunch(), new Firespin(), new Flamethrower(), new Flareblitz(), new Gigaimpact(), new Gyroball(), new Heatcrash(), new Heatwave(), new Heavyslam(), new Hiddenpower(), new Highhorsepower(), new Hyperbeam(), new Irondefense(), new Ironhead(), new Megakick(), new Megapunch(), new Meteorbeam(), new Overheat(), new Protect(), new Reflect(), new Rest(), new Rockblast(), new Rockslide(), new Rocktomb(), new Round(), new Sandstorm(), new Sandtomb(), new Scald(), new Scorchingsands(), new Selfdestruct(), new Sleeptalk(), new Snore(), new Solarbeam(), new Spikes(), new Stealthrock(), new Stoneedge(), new Substitute(), new Willowisp() };
		public override int Weight => 3105;
		public override int ExpYield => 255;
		public override int CatchRate => 45;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 0,
			[Stat.Defense] = 3,
			[Stat.SpecialAttack] = 0,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 0
		};
	}
}