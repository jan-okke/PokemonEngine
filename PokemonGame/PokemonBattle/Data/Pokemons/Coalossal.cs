using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Coalossal : Pokemon
{
	public override string Name => "Coalossal";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Steamengine(), new Abilities.Flamebody() };
	public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Flashfire() };
	public override Stats BaseStats => new Stats(110, 80, 120, 80, 90, 30);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Parabolic;
	public override List<PokemonType> Types => new() {PokemonType.Rock, PokemonType.Fire };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[0] = new List<Move>() { new Moves.Tarshot() },
		[1] = new List<Move>() { new Moves.Tarshot(), new Moves.Flamecharge(), new Moves.Tackle(), new Moves.Smokescreen(), new Moves.Rapidspin(), new Moves.Smackdown() },
		[15] = new List<Move>() { new Moves.Rockpolish() },
		[20] = new List<Move>() { new Moves.Ancientpower() },
		[27] = new List<Move>() { new Moves.Incinerate() },
		[37] = new List<Move>() { new Moves.Stealthrock() },
		[45] = new List<Move>() { new Moves.Heatcrash() },
		[54] = new List<Move>() { new Moves.Rockblast() },
		[63] = new List<Move>() { new Moves.Burnup() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Attract(), new Moves.Bodypress(), new Moves.Bodyslam(), new Moves.Bulldoze(), new Moves.Dig(), new Moves.Earthpower(), new Moves.Earthquake(), new Moves.Endure(), new Moves.Facade(), new Moves.Fireblast(), new Moves.Firepunch(), new Moves.Firespin(), new Moves.Flamethrower(), new Moves.Flareblitz(), new Moves.Gigaimpact(), new Moves.Gyroball(), new Moves.Heatcrash(), new Moves.Heatwave(), new Moves.Heavyslam(), new Moves.Hiddenpower(), new Moves.Highhorsepower(), new Moves.Hyperbeam(), new Moves.Irondefense(), new Moves.Ironhead(), new Moves.Megakick(), new Moves.Megapunch(), new Moves.Meteorbeam(), new Moves.Overheat(), new Moves.Protect(), new Moves.Reflect(), new Moves.Rest(), new Moves.Rockblast(), new Moves.Rockslide(), new Moves.Rocktomb(), new Moves.Round(), new Moves.Sandstorm(), new Moves.Sandtomb(), new Moves.Scald(), new Moves.Scorchingsands(), new Moves.Selfdestruct(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Solarbeam(), new Moves.Spikes(), new Moves.Stealthrock(), new Moves.Stoneedge(), new Moves.Substitute(), new Moves.Willowisp() };
	public override int Weight => 3105;
	public override int ExpYield => 255;
	public override int CatchRate => 45;
	public override Dictionary<Stat, int> EvYield => new()
	{
		[Stat.HP] = 0,
		[Stat.Attack] = 0,
		[Stat.Defense] = 3,
		[Stat.SpecialAttack] = 0,
		[Stat.SpecialDefense] = 0,
		[Stat.Speed] = 0
	};
}